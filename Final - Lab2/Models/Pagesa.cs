using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Pagesa
    {
        [Key]
        public int Id { get; set; }

        public string CardHolder { get; set; }
        public long CardNumber { get; set; }
        public bool Confirmation { get; set; }

        //public int PacientId { get; set; }
        //public virtual Pacient Pacient { get; set; }
        public virtual Receptionist Receptionist { get; set; }

        public virtual Faktura Faktura { get; set; }

        public List<Analizat> Analizats { get; set; }

        
    }
}
