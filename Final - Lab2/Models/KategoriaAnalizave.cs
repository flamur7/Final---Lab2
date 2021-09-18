using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class KategoriaAnalizave
    {
        public int KategoriaAnalizaveId { get; set; }
        public virtual List<Analizat> Analizats { get; set; } = new List<Analizat>();
        public string Lloji { get; set; }
        public string Rendesia { get; set; }
    }
}
