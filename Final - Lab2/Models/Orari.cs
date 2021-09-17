using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Orari
    {
        [Key]
        public int Id { get; set; }
        public string Paradite { get; set; }
        public string Pasdite { get; set; }

        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Receptionist> Receptionists { get; set; }
        public List<Technical> Technicals { get; set; }
    }
}
