using System;

namespace SiparisYonetimi.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        //public string Password { get; set; } gerek yok siliyoruz
        public bool IsActive { get; set; }
        //public bool IsAdmin { get; set; } çünkü müşterinin admin görevi yok
        public DateTime? CreateDate { get; set; } = DateTime.Now; // ? nullable olduğunu  gösterir
    }
}
