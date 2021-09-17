using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Faktura
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NrPersonal { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        
        public int Shuma { get; set; }

        public string Valuta { get; set; }
        public bool Completed { get; set; }

        public virtual List<Faturimi> Faturimis { get; set; } = new List<Faturimi>();

        internal static void DeleteFaktura(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
