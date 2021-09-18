using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Detajet
    {
        public int DetajetId { get; set; }

        [ForeignKey("FeedBack")]
        public int FeedBackId { get; set; }
        public virtual FeedBack FeedBack { get; private set; }
        public string Sherbimet { get; set; }

        public string Arsyja { get; set; }

        public short Vlersimi { get; set; }

    }
}
