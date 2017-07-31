using MIS_DAL.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Miscellaneous
{
   public class AddressDAL
    {
        [Key]
        public Int32 AddressID { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string PreviousAddress { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual EmployeeDAL EmployeeFkID { get; set; }
        [ForeignKey("FamilyID")]
        public virtual EmployeeFamilyMembersDAL EmployeeFamilyMemberFkID { get; set; }


    }
}
