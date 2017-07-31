using MIS_DAL.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
   public class DepartmentTenureDAL
    {
        [Key]
        public Int32 DepartmentTenureID { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime RelievingDate { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

        public virtual int DepartmentFKID { get; set; }
        [ForeignKey("DepartmentFKID")]
        public DepartmentDAL Departments { get; set; }


    }
}
