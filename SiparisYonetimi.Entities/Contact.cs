using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SiparisYonetimi.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
