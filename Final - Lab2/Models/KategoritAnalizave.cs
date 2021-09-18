using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class KategoritAnalizave
    {
        [Key]
        public int Id { get; set; }

        public string Kategoria { get; set; }


        public List<Analizat> Analizats { get; set; }
    }
}
