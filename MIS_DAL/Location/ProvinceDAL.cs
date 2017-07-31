using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Location
{
    class ProvinceDAL
    {
        [Key]
        public Int32 ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public virtual int CountryFKID { get; set; }
        [ForeignKey("CountryFKID")]
        public CountryDAL Countries { get; set; }
    }
}
