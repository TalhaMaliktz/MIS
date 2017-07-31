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
    public class AppointmentDAL
    {
        [Key]
        public Int32 AppointmentID { get; set; }
        public string AppointmentType { get; set; }

        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

        public virtual int DepartmentFKID { get; set; }
        [ForeignKey("DepartmentFKID")]
        public DepartmentDAL Departments { get; set; }
    }
}
