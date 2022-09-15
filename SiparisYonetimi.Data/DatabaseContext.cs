using SiparisYonetimi.Entities;
using System.Data.Entity; // Bu kütüphane entity framework paketinden geliyor

namespace SiparisYonetimi.Data
{
    public class DatabaseContext : DbContext // Burada Entity Frameworkün DbContext sınıfından miras alıyoruz DatabaseContext sınıfından dbcontext leri kullanabilme için // DbContext yazınca ampulden using System.Data.Entity seç
    {
        public DatabaseContext()
        {

        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
