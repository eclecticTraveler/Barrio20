using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexburgBarrio20.Models
{
    public class Address
    {
        public string MainAddress { get; set; }
        public string UnformattedAddress { get; set; }
        public string FormattedAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


    }
}
