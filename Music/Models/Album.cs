using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class Album
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();

        public override string ToString()
        {
            return $"{Title} ({Year})";
        }
    }
}
