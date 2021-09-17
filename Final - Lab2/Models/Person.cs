using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public int NrPersonal { get; set; }
        public String Emri { get; set; }
        public String Mbiemri { get; set; }
        public char Gender { get; set; }
        public int Number { get; set; }
        public String Email { get; set; }
        public String Profesioni { get; set; }
    }
}
