using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public class Common
    {
        public static List<Person> GetDoctors()
        {
            List<Person> doctors=new List<Person>();
            clinicEntities db = new clinicEntities();
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
            clinicEntities db = new clinicEntities();
            Doctor retVal = (from doctor in db.Doctor
                             join employee in db.Employee on doctor.EmployeeId equals employee.Id
                             join person in db.Person on employee.PersonId equals person.Id
                             where person.First_Name == firstName && person.Last_Name == lastName
                             select doctor).First();
            return retVal;
        }
        public static Patient GetPatientById(int id)
        {
            clinicEntities db = new clinicEntities();
            Patient retVal = (from patient in db.Patient
                             join person in db.Person on patient.PersonId equals person.Id
                             where patient.Id == id
                             select patient).First();
            return retVal;
        }
        public static List<Appointment> GetAppointmentsForDoctor(Doctor doctor, DateTime dateTime, string state)
        {
            List<Appointment> appointments = new List<Appointment>();
            clinicEntities db = new clinicEntities();
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
            clinicEntities db = new clinicEntities();
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
            clinicEntities db = new clinicEntities();
            Appointment retVal = (from appointment in db.Appointment
                                  where appointment.Id == id
                                  select appointment).First();
            return retVal;

        }
    }
}
