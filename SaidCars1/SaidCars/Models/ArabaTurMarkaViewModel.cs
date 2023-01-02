using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Models
{
    public class ArabaTurMarkaViewModel
    {
        public Araba Araba { get; set; }
        public List<Tur> Turler { get; set; }
        public List<Marka> Markalar { get; set; }
    }
}
