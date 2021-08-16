using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [DisplayName("Site Baslik ")]
        [Required, StringLength(100,ErrorMessage ="En az 100 karakter girmelisiniz.")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(200, ErrorMessage = "En az 200 karakter girmelisiniz.")]
        public string Keywords { get; set; }
        [DisplayName("Site Aciklama")]
        [Required, StringLength(300, ErrorMessage = "En az 300 karakter girmelisiniz.")]
        public string Description { get; set; }
        [DisplayName("Site Logo")]
        public string LogoURL { get; set; }
        [DisplayName("Site Unvan")]
        public string Unvan { get; set; }
    }
}