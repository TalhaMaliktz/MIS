using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Location
{
    class CityDAL
    {
        [Key]
        public Int32 CityID { get; set; }
        public string CityName { get; set; }
        public virtual int ProvinceFKID { get; set; }
        [ForeignKey("ProvinceFKID")]
        public ProvinceDAL Provinces { get; set; }
    }
}
