using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrevalTripProject.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]

        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]

        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]

        public string BlogImage { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}