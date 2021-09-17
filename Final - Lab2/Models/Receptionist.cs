using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Receptionist : Person
    {
        public virtual Appointment Appointment { get; set; }
        public String OrariPushimit { get; set; }
        public int NrTermineve { get; set; }
        public virtual Orari Orari { get; private set; }

        public List<Pagesa> Pagesas { get; set; }

    }
}
