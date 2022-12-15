using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SiparisYonetimi.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required, Display(Name = "Adı")] // Veritabanında oluşan kolonun nvarcharmax yerşne nvarchar(50) olması için
        public string Name { get; set; }        
        [StringLength(50), Required, Display(Name = "Soyadı")]
        public string Surname { get; set; }
        [StringLength(50), Required]
        public string Email { get; set; }
        [StringLength(15), Display(Name = "Telefon")]
        public string Phone { get; set; }
        [StringLength(50), Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [StringLength(50), Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
        [Display(Name = "Ekleme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now; // ? nullable olduğunu  gösterir

    }
}
