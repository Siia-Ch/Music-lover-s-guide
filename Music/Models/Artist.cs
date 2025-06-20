using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }

        public List<Album> Albums { get; set; }
        public Artist()
        {
            Albums = new List<Album>();
        }

        public override string ToString()
        {
            return $"{Name} ({Genre}, {Country})";
        }
    }
}
