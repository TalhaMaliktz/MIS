using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
    class DesignationDAL
    {
        [Key]
        public Int32 DesignationID { get; set; }
        public string DesignationName { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }
    }
}
