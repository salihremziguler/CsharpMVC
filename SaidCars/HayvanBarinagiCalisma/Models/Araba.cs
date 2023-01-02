using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Models
{
    public class Araba
    {
        [Key]
        public int ArabaId { get; set; }
        [Display(Name ="Adı")]
        
        public string Adi { get; set; }
        [Display(Name ="Model")]
        public int Model { get; set; }
        
        [Display(Name ="Hasarı Var mı?")]
        [Required(ErrorMessage ="Hasar Durumunu Girmelisiniz")]
        public bool HasarliMi { get; set; }
        [Display(Name = "Rezerve mi?")]
        public bool RezerveMi { get; set; } = false;
        [Display(Name ="Varsa Araç hakkında ek bilgiler")]
        public string EkBilgiler { get; set; }
        [Display(Name ="Fotoğraf")]
        public string Foto { get; set; }

        //Model ile İlişki

        [ForeignKey("Marka")]
        public int MarkaId { get; set; }
        public virtual Marka Marka { get; set; }
        //Tür ile ilişki
       [ ForeignKey("Tur")]
        public int TurId { get; set; }
        public virtual Tur Tur { get; set; }
    }
}
