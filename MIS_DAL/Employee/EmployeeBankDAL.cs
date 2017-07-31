using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Employee
{
   public class EmployeeBankDAL
    {
        [Key]
        public Int32 BankID { get; set; }
        public string BankTitle { get; set; }
        public string BankBranch { get; set; }
        public string AccountTitle { get; set; }
        public Int32 AccountNumber { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }
    }
}
