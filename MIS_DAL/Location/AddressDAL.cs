using MIS_DAL.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Location
{
    public   class AddressDAL
    {
        [Key]
        public Int32 AddressID { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string PreviousAddress { get; set; }
        public int PostalCode { get; set; }
        public string Region { get; set; }

        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

        public virtual int FamilyFKID { get; set; }
        [ForeignKey("FamilyFKID")]
        public EmployeeFamilyMembersDAL EmployeeFamilyMembers { get; set; }
    }
}
