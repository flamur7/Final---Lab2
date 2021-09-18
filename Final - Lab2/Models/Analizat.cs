using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Analizat
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Technical")]
        public int TechnicalId { get; set; }
        public virtual Technical Technical { get; private set; }

        public string Emri { get; set; }
        public string Pershkerimi { get; set; }

        public List<Pacient> Pacients { get; set; }

        public virtual Nurse Nurse { get; set; }

       
        public virtual KategoritAnalizave KategoritAnalizave { get; set; }

        public virtual Pagesa Pagesa { get; set; }
    }
}
