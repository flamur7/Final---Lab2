using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Pagesa
    {
        [Key]
        public int PagesaId { get; set; }

        [ForeignKey("Faktura")]
        public int FakturaId { get; set; }
        public virtual Faktura Faktura { get; private set; }

        [ForeignKey("Pacient")]
        public int PacientiId { get; set; }
        public virtual Pacient Pacient { get; private set; }


    }
}
