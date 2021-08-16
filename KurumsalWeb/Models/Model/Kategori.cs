using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Kategori")] // Tablo ismini belirttik
    public class Kategori
    {
        [Key] // kategoriId key olarak belirlendi
        public int KategoriId { get; set; }
        [Required,StringLength(50,ErrorMessage = "50 karakter olmalisir")]
        public string KategoriAd { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        /*
         *collection şeklinde  bir liste içerecek 
        yani sunu demeye calısıyotuz her bir blog bir 
        category e aittir demeye çalışıyoruz.
         * */
    }
}