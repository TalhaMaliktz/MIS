using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Location
{
    class VillageDAL
    {
        [Key]
        public Int32 VillageID { get; set; }
        public string VillageName { get; set; }
        public virtual int DistrictFKID { get; set; }
        [ForeignKey("DistrictFKID")]
        public DistrictDAL Districts { get; set; }
    }
}
