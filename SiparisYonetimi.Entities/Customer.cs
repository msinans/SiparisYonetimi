using System;
using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(50), Required]
        public string Surname { get; set; }
        [StringLength(50), Required]
        public string Email { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        //public string Password { get; set; } gerek yok siliyoruz
        public bool IsActive { get; set; }
        //public bool IsAdmin { get; set; } çünkü müşterinin admin görevi yok
        public DateTime? CreateDate { get; set; } = DateTime.Now; // ? nullable olduğunu  gösterir
    }
}
