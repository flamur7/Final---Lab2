using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Nurse : Person
    {
        public String OrariPushimit { get; set; }
        public String Analizat { get; set; }

        

        public int AnalizaId { get; set; }
        public virtual Analizat Analiza { get; set; }
    }
}
