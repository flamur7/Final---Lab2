using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class KontrollaMjeksore
    {
        [Key]
        public int KontrollaMjesoreId { get; set; }

        public string Pershkrimi { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; private set; }



        public virtual Terapi Terapi { get; set; }

    }
}
