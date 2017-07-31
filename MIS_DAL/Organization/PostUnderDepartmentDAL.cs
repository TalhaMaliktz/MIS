using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
  public  class PostUnderDepartmentDAL
    {
        [Key]
        public Int32 PostUnderDepartmentID { get; set; }
        public int SanctionStrength { get; set; }
        public int ActualStrength { get; set; }
        public string Remarks { get; set; }
        public virtual int PostID { get; set; }
        [ForeignKey("PostID")]
        public  PostDAL Posts { get; set; }


    }
}
