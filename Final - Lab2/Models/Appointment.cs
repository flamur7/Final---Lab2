using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public virtual List<Analizat> Analizats { get; set; } = new List<Analizat>();

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }



        public int PacientId { get; set; }
        public virtual Pacient Pacient { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Receptionist> Receptionists { get; set; }


    }
}
