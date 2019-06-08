using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexburgBarrio20.Models
{
    public class Category
    {
        public string Name { get; set; }
        public long Counter { get; set; }
        public byte Image { get; set; }
        public long NumberOfVisits { get; set; }
        public IEnumerable<Suggestion> Suggestions { get; set; }


    }
}
