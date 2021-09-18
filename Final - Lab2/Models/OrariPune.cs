using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class OrariPune
    {
        [Key]
        public int OrariPuneId { get; set; }

        [ForeignKey("Technical")]
        public int TechnicalId { get; set; }
        public virtual Technical Technical { get; private set; } 



        public string Dita { get; set; }
        public string Koha { get; set; }
        public string Java { get; set; }



        public List<Nurse> Nurses { get; set; }
        public List<Receptionist> Receptionists { get; set; }
    }
}

