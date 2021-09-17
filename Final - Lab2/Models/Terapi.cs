using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Terapi
    {
        [Key]
        public int TerapiId { get; set; }

        [ForeignKey("Pacient")]
        public int PacientiId { get; set; }
        public virtual Pacient Pacient { get; private set; }

        public string Semundje { get; set; }
        public string Barnat { get; set; }

        public string Kohezgjatja { get; set; }

        public List<KontrollaMjeksore> KontrollaMjeksores { get; set; }

    }
}
