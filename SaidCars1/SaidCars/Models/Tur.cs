using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Models
{
    public class Tur
    {
        [Key]
        public int TurId { get; set; }
        [Display(Name ="Tür Adı")]
        [Required(ErrorMessage ="Tür Adı Girilmelidir")]
        
        public string TurAdi { get; set; }
       
        //Araba ile ilişki
        public virtual List<Araba> Arabalar { get; set; }
    }
}
