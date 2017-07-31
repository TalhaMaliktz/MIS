using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
   public class PostDAL
    {
        [Key]
        public Int32 PostID { get; set; }
        public string PostTitle { get; set; }
        public string PBCGroup { get; set; }
        public string PostStatus { get; set; }

    }
}
