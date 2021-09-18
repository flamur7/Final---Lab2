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

        


        public List<Doctor> Doctors { get; set; }
        public virtual Terapi Terapi { get; set; }

        public int PagesaId { get; set; }
        public virtual Pagesa Pagesa { get; set; }
    }
}
