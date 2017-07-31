using MIS_DAL.Location;
using MIS_DAL.Miscellaneous;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Organization
{
    public class StationDAL
    {
        [Key]
        public Int32 StationID { get; set; }
        public string StationName { get; set; }
        public virtual int AddressFKID { get; set; }
        [ForeignKey("AddressFKID")]
        public AddressDAL Address { get; set; }


    }
}
