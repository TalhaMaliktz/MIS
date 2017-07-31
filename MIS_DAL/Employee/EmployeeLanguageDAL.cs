using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
  public  class EmployeeLanguageDAL
    {
        [Key]
        public Int32 LanguageID { get; set; }
        public string Language { get; set; }
        public Nullable<bool> CanRead { get; set; }
        public Nullable<bool> CanWrite { get; set; }
        public Nullable<bool> CanSpeak { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

    }
}
