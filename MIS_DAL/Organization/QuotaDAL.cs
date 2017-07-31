using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
   public class QuotaDAL
    {
        [Key]
        public Int32 QuotaID { get; set; }
        public string QuotaType { get; set; }
        public int Strength { get; set; }

    }
}
