using MIS_DAL.Organization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
  public  class EmployeeDAL
    {
        [Key]
        public Int32 EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }          
        public string MaritalStatus { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ActivationCode { get; set; }

        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string ServiceStatus { get; set; }
        public string Religion { get; set; }
        public string Domicile { get; set; }
        public int CNIC { get; set; }
        public DateTime RetirementYear { get; set; }
        public string ContractType { get; set; }
        public Nullable<bool> ContractBased  { get; set; }
        public Nullable<byte>[] Photo { get; set; }
        public Gender? EmployeeGender { get; set; }

        public Sect? EmployeeSect { get; set; }
        public enum Sect
        {
            Ahletashi,Ahlesunnah,Ahlewahab,Ahlehadith,Deoband,Ismaili,Ahmadi
        }
        public enum Gender
        {
            Male,Female,Transgender
        }
        public string SystemRole { get; set; }
        public virtual int QuotaFKID { get; set; }
       
        [ForeignKey("QuotaFKID")]
        public QuotaDAL Quotas { get; set; }
    }
}
