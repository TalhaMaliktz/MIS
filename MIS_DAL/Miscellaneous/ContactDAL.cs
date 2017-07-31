using MIS_DAL.Employee;
using MIS_DAL.Location;
using MIS_DAL.Organization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Miscellaneous
{
   public class ContactDAL
    {
        [Key]
        public Int32 ContactID { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }

        public int LandLineNumber { get; set; }
        public int FaxNumber { get; set; }
        public int EmergencyContact { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

        public virtual int DepartmentFKID { get; set; }
        [ForeignKey("DepartmentFKID")]
        public DepartmentDAL Departments { get; set; }

        public virtual int PostFKID { get; set; }
        [ForeignKey("PostFKID")]
        public PostDAL Posts { get; set; }

        public virtual int StationFKID { get; set; }
        [ForeignKey("StationFKID")]
        public StationDAL Stations { get; set; }

        public virtual int AddressFKID { get; set; }
        [ForeignKey("AddressFKID")]
        public AddressDAL Address { get; set; }

    }
}
