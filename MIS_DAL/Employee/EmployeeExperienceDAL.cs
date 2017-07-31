using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
   public class EmployeeExperienceDAL
    {
        [Key]
        public Int32 ExperienceID { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobTitle { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

    }
}
