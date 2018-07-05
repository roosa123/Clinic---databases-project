﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Text.RegularExpressions;
using System.Data.Entity.Validation;

namespace BusinessLayer
{
    public class Common
    {
        public static clinicEntities db = new clinicEntities();

        public static List<Person> GetDoctors()
        {
            List<Person> doctors=new List<Person>();
            //clinicEntities db = new clinicEntities();
            var result = from doctor in db.Doctor
                         join employee in db.Employee on doctor.EmployeeId equals employee.Id
                         join person in db.Person on employee.PersonId equals person.Id
                         select person;
            foreach(var item in result)
            {
                doctors.Add(item);
            }
            return doctors;
        }
        public static Doctor GetDoctorByName(string firstName, string lastName)
        {
            //clinicEntities db = new clinicEntities();
            Doctor retVal = (from doctor in db.Doctor
                             join employee in db.Employee on doctor.EmployeeId equals employee.Id
                             join person in db.Person on employee.PersonId equals person.Id
                             where person.First_Name == firstName && person.Last_Name == lastName
                             select doctor).First();
            return retVal;
        }
        public static Patient GetPatientById(int id)
        {
            //clinicEntities db = new clinicEntities();
            Patient retVal = (from patient in db.Patient
                             join person in db.Person on patient.PersonId equals person.Id
                             where patient.Id == id
                             select patient).First();
            return retVal;
        }
        public static List<Appointment> GetAppointmentsForDoctor(Doctor doctor, DateTime dateTime, string state)
        {
            List<Appointment> appointments = new List<Appointment>();
            //clinicEntities db = new clinicEntities();
            var result = from appointment in db.Appointment
                             where appointment.DoctorId == doctor.Id
                             && appointment.Status==state
                             && appointment.dt_Register >= dateTime
                             select appointment;
            foreach (var item in result)
            {
                appointments.Add(item);
            }
            return appointments;
        }
        public static List<Appointment> GetAppointmentsForDoctor(Doctor doctor, DateTime dateTime)
        {
            List<Appointment> appointments = new List<Appointment>();
            //clinicEntities db = new clinicEntities();
            var result = from appointment in db.Appointment
                         where appointment.DoctorId == doctor.Id
                         && appointment.dt_Complete_Cancel >= dateTime
                         select appointment;
            foreach (var item in result)
            {
                appointments.Add(item);
            }
            return appointments;
        }
        public static List<Appointment> GetAppointmentsForDoctor(string firstName, string lastName,DateTime dateTime, string state)
        {
            if (state == "-")
                return GetAppointmentsForDoctor(GetDoctorByName(firstName, lastName), dateTime);
            return GetAppointmentsForDoctor(GetDoctorByName(firstName, lastName), dateTime, state);
        }
        public static Appointment GetAppointmentById(int id)
        {
            //clinicEntities db = new clinicEntities();
            Appointment retVal = (from appointment in db.Appointment
                                  where appointment.Id == id
                                  select appointment).First();
            return retVal;

        }

        public static List<Person> GetPatients()
        {
            List<Person> patients = new List<Person>();
            //clinicEntities db = new clinicEntities();
            var result = from patient in db.Patient
                         join person in db.Person on patient.PersonId equals person.Id
                         select person;
            foreach (var item in result)
            {
                patients.Add(item);
            }
            return patients;
        }
        public static void UpdatePatient(Patient patient)
        {
            var res = (from el in db.Patient
                       where el.Id == patient.Id
                       select el).SingleOrDefault();

            if(res == null)
                return;

            res.Person.First_Name = patient.Person.First_Name;
            res.Person.Last_Name = patient.Person.Last_Name;
            res.Person.Date_of_birth = patient.Person.Date_of_birth;
            res.Person.Sex = patient.Person.Sex;
            res.PESEL = patient.PESEL;
            res.Insurance_Number = patient.Insurance_Number;
            res.Person.Address.Country = patient.Person.Address.Country;
            res.Person.Address.City = patient.Person.Address.City;
            res.Person.Address.Post_Code = patient.Person.Address.Post_Code;
            res.Person.Address.Street = patient.Person.Address.Street;
            res.Person.Address.House_Number = patient.Person.Address.House_Number;
            res.Person.Address.Flat_Number = patient.Person.Address.Flat_Number;
            res.Person.Phone_number = patient.Person.Phone_number;

            db.SaveChanges();
        }
        public static Patient GetPatientByNameAndPESEL(string firstName, string lastName, string PESEL)
        {
            //clinicEntities db = new clinicEntities();
            Patient result = (from patient in db.Patient
                             join person in db.Person on patient.PersonId equals person.Id
                             where person.First_Name == firstName && person.Last_Name == lastName && patient.PESEL == PESEL
                             select patient).First();
            return result;
        }
        public static List<Patient> GetPatientByName(string firstName, string lastName)
        {
            List<Patient> patients = new List<Patient>();

            var result = from patient in db.Patient
                            join person in db.Person on patient.PersonId equals person.Id
                            where person.First_Name == firstName && person.Last_Name == lastName
                            select patient;

            foreach (var item in result)
            {
                patients.Add(item);
            }
            return patients;
        }
        public static int InsertAppointment(DateTime date, DateTime time, string doctor, Patient patient)
        {
            string[] ducky = doctor.Split(' ');
            string firstName = ducky[0];
            string lastName = ducky[1];

            date = date.AddHours(time.Hour);
            date = date.AddMinutes(time.Minute);
            int result = 0;

            Appointment appointment = new Appointment();

            appointment.Doctor = GetDoctorByName(firstName, lastName);
            appointment.DoctorId = appointment.Doctor.Id;

            appointment.dt_Register = date;
            appointment.Patient = patient;
            appointment.PatientId = appointment.Patient.Id;
            appointment.Description = "";
            appointment.Status = "Nowa wizyta";

            db.Appointment.Add(appointment);
            //result = db.SaveChanges();

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch(System.Data.Entity.Infrastructure.DbUpdateException exc)
            {
                    System.Console.WriteLine("Error: {1}", exc.Message);
            }

            return result;
        }
        public static int DeleteAppointment(Appointment appointment)
        {
            //clinicEntities db = new clinicEntities();
            db.Appointment.Remove(appointment);
            return db.SaveChanges();
        }
        public static PhysicalExamination GetPhysicalExaminationByCode(int code)
        {
            PhysicalExamination retVal = (from examination in db.Examinations
                                          join physEx in db.PhysicalExamination on examination.Code equals physEx.ExaminationCode
                                          where physEx.ExaminationCode == code.ToString()
                                          select physEx).First();
            return retVal;
        }
        public static LaboratoryExamination GetLaboratoryExaminationByCode(int code)
        {
            LaboratoryExamination retVal = (from examination in db.Examinations
                                          join labEx in db.LaboratoryExamination on examination.Code equals labEx.ExaminationCode
                                          where labEx.ExaminationCode == code.ToString()
                                          select labEx).First();
            return retVal;
        }
    }
}
