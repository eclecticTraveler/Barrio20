using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexburgBarrio20.Models
{
    public class Suggestion
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SuggestionLink> Links{ get; set; }
        public Address Address { get; set; }
        public int Telephone { get; set; }
        public byte Image { get; set; }
        public long LikesCounter { get; set; }

    }
}
