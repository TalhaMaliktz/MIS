using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
   public class EmployeeFamilyMembersDAL
    {
        [Key]
        public Int32 FamilyID { get; set; }
        public string RelationshipType { get; set; }
        public string Name { get; set; }
        public DateTime DOB  { get; set; }
        public Nullable<byte>[] Photo { get; set; }
        public DateTime DateOfMarriage { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }
    }
}
