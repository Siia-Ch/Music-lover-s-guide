﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class Song
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Duration:mm\\:ss})";
        }


    }
}
