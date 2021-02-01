using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Models
{
 
    //[Bind(nameof(Title), nameof(Director))]
    public class Movie
    {
        public int Id { get; set; }
        [DisplayName("Film Başlığı")]
        [Required(ErrorMessage ="Film basligi zorunludur.")]
        public String Title { get; set; }

        [DisplayName("Yönetmen")]
        public String Director { get; set; }

        [DisplayName("Film Açıklaması")]
        [Required(ErrorMessage = "Film açıklama alanı zorunludur.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Aciklama alani 10 ile 100 karakter arasinda olmalidir")]
        public String Description { get; set; }
        public List<String> Actors { get; set; }
        public String ImageUrl { get; set; }
        [Required(ErrorMessage = "Popularity boş geçilemez")]
        [Range(0,5, ErrorMessage = "0 ile 5 arasinda deger girilmelidir.")]
        public double? Popularity { get; set; }
        public Genre Genre { get; set; }
    }
}
