﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Technical : Person
    {
        public String Shkollimi { get; set; }
        public String Pervoja { get; set; }
        public virtual Orari Orari { get; private set; }
        public virtual Analizat Analiza { get; set; }
    }
}
