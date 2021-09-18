using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public virtual List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public virtual List<KontrollaMjeksore> KontrollaMjeksores { get; set; } = new List<KontrollaMjeksore>();
        public int NrPersonal { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public char Gender { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Specalizimi { get; set; }
    }
}
