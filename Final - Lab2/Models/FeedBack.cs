using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public virtual List<Detajet> Detajets { get; set; } = new List<Detajet>();
        public string Subject { get; set; }

        public string Field { get; set; }
    }
}
