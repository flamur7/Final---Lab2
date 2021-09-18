using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Technical
    {
        [Key]
        public int TechnicalId { get; set; }
        public virtual List<OrariPune> OrariPunes { get; set; } = new List<OrariPune>();
        public virtual List<Analizat> Analizats { get; set; } = new List<Analizat>();
        public int NrPersonal { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public char Gender { get; set; }

        public string Pervoja { get; set; }
        public string Shkollimi { get; set; }
    }
}
