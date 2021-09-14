using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Pacient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NrPersonal { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        public char Gender { get; set; }

        public string Note { get; set; }


        public virtual List<Terapi> Terapis { get; set; } = new List<Terapi>();
    }
}
