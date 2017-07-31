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
    class DistrictDAL
    {
        [Key]
        public Int32 DistrictID { get; set; }
        public string DistrictName { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

        public virtual int CityFKID { get; set; }
        [ForeignKey("CityFKID")]
        public CityDAL Cities { get; set; }
    }
}
