using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
   public class DepartmentDAL
    {
        [Key]
        public Int32 DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentType { get; set; }

        public virtual int StationFKID { get; set; }
        [ForeignKey("StationFKID")]
        public StationDAL Stations { get; set; }
    }
}
