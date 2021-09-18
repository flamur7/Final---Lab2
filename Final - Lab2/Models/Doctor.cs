using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Doctor : Person
    {
        public virtual Appointment Appointment { get; set; }
        public virtual KontrollaMjeksore KontrollaMjeksore { get; set; }
       
        public String Specalizimi { get; set; }
        public String Titulli { get; set; }
    }
}
