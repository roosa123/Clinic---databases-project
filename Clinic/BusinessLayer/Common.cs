using System;
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
            try { 
            //clinicEntities db = new clinicEntities();
                Doctor retVal = (from doctor in db.Doctor
                                 join employee in db.Employee on doctor.EmployeeId equals employee.Id
                                 join person in db.Person on employee.PersonId equals person.Id
                                 where person.First_Name == firstName && person.Last_Name == lastName
                                 select doctor).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static Patient GetPatientById(int id)
        {
            try {
                //clinicEntities db = new clinicEntities();
                Patient retVal = (from patient in db.Patient
                                  join person in db.Person on patient.PersonId equals person.Id
                                  where patient.Id == id
                                  select patient).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
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
            try
            {
            //clinicEntities db = new clinicEntities();
                Appointment retVal = (from appointment in db.Appointment
                                      where appointment.Id == id
                                      select appointment).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            //clinicEntities db = new clinicEntities();
            var result = from employee in db.Employee
                         join person in db.Person on employee.PersonId equals person.Id
                         select employee;
            foreach (var item in result)
            {
                employees.Add(item);
            }
            return employees;
        }
        public static List<Employee> GetEmployeeByRoleAndStatus(string role, int status)
        {
            DateTime date = DateTime.Today;
            List<Employee> results = new List<Employee>();

            IQueryable<Employee> result;

            switch (status)
            {
                case 0:
                    result = from employee in db.Employee
                                 where employee.Position == role
                                 select employee;
                    break;
                case 1:
                    result = from employee in db.Employee
                                 where employee.Position == role && employee.dt_AccountValidityFrom <= date && employee.dt_AccountValidityTo >= date
                                 select employee;
                    break;
                case 2:
                    result = from employee in db.Employee
                                 where employee.Position == role && employee.dt_AccountValidityFrom <= date && employee.dt_AccountValidityTo >= date
                                 select employee;
                    break;
                case 3:
                    result = from employee in db.Employee
                                 where employee.Position == role && (employee.dt_AccountValidityFrom >= date ||  employee.dt_AccountValidityTo <= date)
                                 select employee;
                    break;
                default:
                    result = null;
                    break;
            }

            if (result == null)
                return new List<Employee>();

            foreach (var item in result)
            {
                results.Add(item);
            }

            return results;
        }
        public static int InsertPatient(Patient patient)
        {
            db.Patient.Add(patient);
            return db.SaveChanges();
        }
        public static Doctor GetDoctorById(int id)
        {
            try { 
            //clinicEntities db = new clinicEntities();
                Doctor retVal = (from doctor in db.Doctor
                             join employee in db.Employee on doctor.EmployeeId equals employee.Id
                             join person in db.Person on employee.PersonId equals person.Id
                             where person.Id == id
                             select doctor).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static int UpdatePassword(Employee user)
        {
            //clinicEntities db = new clinicEntities();
            Employee res = (from employee in db.Employee
                             join person in db.Person on employee.PersonId equals person.Id
                             where employee.Id == user.Id
                             select employee).SingleOrDefault();

            if (res == null)
                return 0;

            res.Password = user.Password;

            return db.SaveChanges();
        }
        public static int UpdateEmployee(Employee user)
        {
            var res = (from employee in db.Employee
                       join person in db.Person on employee.Id equals person.Id
                       join address in db.Address on person.AddressId equals address.Id
                       where employee.Id == person.Id
                       select employee).SingleOrDefault();

            if (res == null)
                return 0;

            res.Person.First_Name = user.Person.First_Name;
            res.Person.Last_Name = user.Person.Last_Name;
            res.Person.Date_of_birth = user.Person.Date_of_birth;
            res.Person.Sex = user.Person.Sex;
            res.Person.Address.Country = user.Person.Address.Country;
            res.Person.Address.City = user.Person.Address.City;
            res.Person.Address.Post_Code = user.Person.Address.Post_Code;
            res.Person.Address.Street = user.Person.Address.Street;
            res.Person.Address.House_Number = user.Person.Address.House_Number;
            res.Person.Address.Flat_Number = user.Person.Address.Flat_Number;
            res.Person.Phone_number = user.Person.Phone_number;

            return db.SaveChanges();
        }
        public static Employee GetEmployeeById(int id)
        {
            try
            {
                Employee retVal = (from employee in db.Employee
                              join person in db.Person on employee.PersonId equals person.Id
                              where employee.Id == id
                              select employee).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static LaboratoryExamination GetLaboratoryExaminationByName(string name)
        {
            try
            {
                LaboratoryExamination retVal = (from examination in db.Examinations
                                          join labEx in db.LaboratoryExamination on examination.Code equals labEx.ExaminationCode
                                          where examination.Name == name
                                          select labEx).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static PhysicalExamination GetPhysicalExaminationByName(string name)
        {
            try
            {
                PhysicalExamination retVal = (from examination in db.Examinations
                                          join physEx in db.PhysicalExamination on examination.Code equals physEx.ExaminationCode
                                          where examination.Name == name
                                          select physEx).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static LaboratoryExamination GetLaboratoryExaminationByCodeAndName(int code, string name)
        {
            try
            {
                LaboratoryExamination retVal = (from examination in db.Examinations
                                          join physEx in db.LaboratoryExamination on examination.Code equals physEx.ExaminationCode
                                          where examination.Name == name && physEx.ExaminationCode == code.ToString()
                                          select physEx).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }
        public static PhysicalExamination GetPhysicalExaminationByCodeAndName(int code, string name)
        {
            try
            {
                PhysicalExamination retVal = (from examination in db.Examinations
                                          join physEx in db.PhysicalExamination on examination.Code equals physEx.ExaminationCode
                                          where examination.Name == name && physEx.ExaminationCode == code.ToString()
                                          select physEx).First();
            return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public static List<PhysicalExamination> GetPhysExaminationByPatinetId(int id)
        {
            List<PhysicalExamination> results = new List<PhysicalExamination>();

            var result = from appointment in db.Appointment
                         join examination in db.PhysicalExamination on appointment.Id equals examination.AppointmentId
                         where appointment.Patient.Id == id
                         select examination;

            foreach (var item in result)
            {
                results.Add(item);
            }

            return results;
        }
        public static List<LaboratoryExamination> GetLabExamiantionByPatinetId(int id)
        {
            List<LaboratoryExamination> results = new List<LaboratoryExamination>();

            var result = from appointment in db.Appointment
                         join examination in db.LaboratoryExamination on appointment.Id equals examination.AppointmentId
                         where appointment.Patient.Id == id
                         select examination;

            foreach (var item in result)
            {
                results.Add(item);
            }

            return results;
        }
        public static List<Appointment> GetAppointmentByPatinetId(int id)
        {
            List<Appointment> results = new List<Appointment>();

            var result = from appointment in db.Appointment
                         where appointment.Patient.Id == id
                         select appointment;

            foreach (var item in result)
            {
                results.Add(item);
            }

            return results;
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
        public static int UpdatePatient(Patient patient)
        {
            var res = (from el in db.Patient
                       join person in db.Person on el.PersonId equals person.Id
                       join address in db.Address on person.AddressId equals address.Id
                       where el.Id == patient.Id
                       select el).SingleOrDefault();

            if(res == null)
                return 0;

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

            return db.SaveChanges();
        }
        public static int UpdateLaboratoryExamination(LaboratoryExamination examination)
        {
            var res = (from el in db.LaboratoryExamination
                       where el.Id == examination.Id
                       select el).SingleOrDefault();

            if (res == null)
                return 0;

            res.dt_Complete_Cancel = examination.dt_Complete_Cancel;
            res.dt_Confirmation = examination.dt_Confirmation;
            res.Result = examination.Result;
            res.Status = examination.Status;
            res.Supervisor_Note = res.Supervisor_Note;

            return db.SaveChanges();
        }
        public static Patient GetPatientByNameAndPESEL(string firstName, string lastName, string PESEL)
        {
            try
            {
                //clinicEntities db = new clinicEntities();
                Patient result = (from patient in db.Patient
                             join person in db.Person on patient.PersonId equals person.Id
                             where person.First_Name == firstName && person.Last_Name == lastName && patient.PESEL == PESEL
                             select patient).First();
            return result;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
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
        public static int InsertAppointment(DateTime date, DateTime time, string doctor, Patient patient, int registrarId)
        {
            string[] ducky = doctor.Split(' ');
            string firstName = ducky[0];
            string lastName = ducky[1];

            date = date.AddHours(time.Hour);
            date = date.AddMinutes(time.Minute);

            Appointment appointment = new Appointment();

            appointment.Doctor = GetDoctorByName(firstName, lastName);
            appointment.DoctorId = appointment.Doctor.Id;

            appointment.dt_Register = date;
            appointment.dt_Complete_Cancel = DateTime.Today;
            appointment.Patient = patient;
            appointment.PatientId = appointment.Patient.Id;
            appointment.Description = "";
            appointment.Status = "Zarejestrowana";
            appointment.RegisterPersonId = registrarId;

            db.Appointment.Add(appointment);
            return db.SaveChanges();
        }
        public static int DeleteAppointment(Appointment appointment)
        {
            //clinicEntities db = new clinicEntities();
            db.Appointment.Remove(appointment);
            return db.SaveChanges();
        }
        public static PhysicalExamination GetPhysicalExaminationByCode(int code)
        {
            try {
                PhysicalExamination retVal = (from examination in db.Examinations
                                              join physEx in db.PhysicalExamination on examination.Code equals physEx.ExaminationCode
                                              where physEx.ExaminationCode == code.ToString()
                                              select physEx).First();
                return retVal;
            }
            catch(InvalidOperationException)
            {
                return null;
            }
        }
        public static LaboratoryExamination GetLaboratoryExaminationByCode(int code)
        {
            try
            {
                LaboratoryExamination retVal = (from examination in db.Examinations
                                          join labEx in db.LaboratoryExamination on examination.Code equals labEx.ExaminationCode
                                          where labEx.ExaminationCode == code.ToString()
                                          select labEx).First();
            return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static Examinations GetOnlyPhysicalExaminationByCode(int code)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                              where examination.Code == code.ToString() && examination.Type== "Phisycal"
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static Examinations GetOnlyLaboratoryExaminationByCode(int code)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                       where examination.Code == code.ToString() && examination.Type == "Laboratory"
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static Examinations GetOnlyLaboratoryExaminationByName(string name)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                       where examination.Name == name && examination.Type == "Laboratory"
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static void SetDiagnosisAndDescpritionForAppointment(string diagnosis, string description, int id)
        {
            Appointment retVal = GetAppointmentById(id);
            retVal.Description = description;
            retVal.Diagnosis = diagnosis;
            db.SaveChanges();
        }
        public static DateTime DefaultDT
        {
            get
            {
                return Convert.ToDateTime("1753/2/2");
            }
        }
        public static Examinations GetOnlyPhysicalExaminationByName(string name)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                       where examination.Name == name && examination.Type == "Phisycal"
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public static Examinations GetOnlyLaboratoryExaminationByCodeAndName(int code, string name)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                       where examination.Name == name && examination.Type == "Laboratory" && examination.Code == code.ToString()
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }
        public static Examinations GetOnlyPhysicalExaminationByCodeAndName(int code, string name)
        {
            try
            {
                Examinations retVal = (from examination in db.Examinations
                                       where examination.Name == name && examination.Type == "Phisycal" && examination.Code == code.ToString()
                                       select examination).First();
                return retVal;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }


        public static List<LaboratoryExamination> GetLaboratoryExaminationByDateAndStatus(DateTime dt, string status)
        {
            List<LaboratoryExamination> results = new List<LaboratoryExamination>();

            var result = from examination in db.Examinations
                                            join labEx in db.LaboratoryExamination on examination.Code equals labEx.ExaminationCode
                                            where labEx.dt_Request == dt && labEx.Status == status
                                            select labEx;

            foreach(var item in result)
            {
                results.Add(item);
            }

            return results;
        }
        public static int GetPhysicalExaminationsCount()
        {
            int maxID = (from physEx in db.PhysicalExamination
                          select physEx.Id).Max();
            return maxID;

        }
        public static int GetLaboratoryExaminationsCount()
        {
            int maxID = (from labEx in db.LaboratoryExamination
                         select labEx.Id).Max();
            return maxID;

        }

        public static void InsertPhysicalExamination(PhysicalExamination examination)
        {
            examination.Examinations = null;
            db.PhysicalExamination.Add(examination);
            try {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
            {
                System.Console.WriteLine("Error: {1}", exc.Message);
            }
        }

        public static int InsertLaboratoryExamination(LaboratoryExamination examination)
        {
            int result = 0;
            examination.Examinations = null;
            db.LaboratoryExamination.Add(examination);
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
                return 1;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
            {
                System.Console.WriteLine("Error: {1}", exc.Message);
                return 1;
            }

            return result;
        }
    }
}
