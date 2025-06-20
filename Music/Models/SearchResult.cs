using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class SearchResult
    {
        public string DisplayText { get; set; }
        public object Data { get; set; } 
        public string Type { get; set; }

        public override string ToString() => DisplayText;
    }
}
