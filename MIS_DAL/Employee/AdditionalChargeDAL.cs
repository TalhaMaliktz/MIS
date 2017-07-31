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
    public class AdditionalChargeDAL
    {
        [Key]
        public Int32 AdditionalChargeID { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }
        public virtual int DepartmentFKID { get; set; }
        [ForeignKey("DepartmentFKID")]
        public DepartmentDAL Departments { get; set; }

        public virtual int PostFKID { get; set; }
        [ForeignKey("PostFKID")]
        public PostDAL Posts { get; set; }


    }
}
