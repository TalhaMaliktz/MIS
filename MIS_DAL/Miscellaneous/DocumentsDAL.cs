using MIS_DAL.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Miscellaneous
{
  public  class DocumentsDAL
    {
        [Key]
        public Int32 DocumentsID { get; set; }
        public string DocumentType { get; set; }
        public DateTime DateOfSubmission { get; set; }
        public byte[] Image { get; set; }
        public virtual int EmployeeFKID { get; set; }
        [ForeignKey("EmployeeFKID")]
        public EmployeeDAL Employees { get; set; }

    }
}
