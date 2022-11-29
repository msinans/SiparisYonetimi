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
        public virtual DbSet<Slide> Slides { get; set; }
    }
}
/*
 * proje yaparken classları ve database contexti kurduktan sonra veritabanını otomatik oluşturdmak yerine migration ile oluşturmamız gerekir.
 * Migration ı aktif etmek için visual studio da en üst menüden tools>Nuget Pac... Manager> Package Manage console menüsünü aktif ediyoruz. Aşağıdaki Pmc alanını açıyoruz.
 * Önce Default Project Bölümünden database context inizin bulunduğu Data katanını seçiyoruz
 * Sonra aşağıdaki kod alanına Enable-migrations yazıp enter a basarak Initialcreate classını oluşturulmasını sağlıyoruz
 * oluşan configuration sınıfının içerisinde başlangıç verisi oluşturabileceğimiz send metodu oluşuyor bunu kullanarak veritabanı oluştuktan sonra örnek data oluşturabiliriz.
 * Eğer enable-migraions tan sonra initial create class ı oluşmazsa P.M.C. komut ekranına add-migration InitialCreate yazıp enter a basarak kendimiz oluşturabiliriz
 */
