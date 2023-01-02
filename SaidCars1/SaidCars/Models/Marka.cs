using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Models
{
    public class Marka
    {
        [Key]
        public int MarkaId { get; set; }
        [Display(Name ="Marka Adı")]
        [Required(ErrorMessage ="Marka Adı Girilmelidir")]
        
        public string MarkaAdi { get; set; }
        //Hayvan ile ilişki
        public virtual List<Araba> Arabalar { get; set; }
    }
}
