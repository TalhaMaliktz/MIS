using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_DAL.Location
{
    class CountryDAL
    {
        [Key]
        public Int32 CountryID { get; set; }
        public string CountryName { get; set; }

        public virtual int AddressFKID { get; set; }
        [ForeignKey("AddressFKID")]
        public AddressDAL Address { get; set; }
    }
}
