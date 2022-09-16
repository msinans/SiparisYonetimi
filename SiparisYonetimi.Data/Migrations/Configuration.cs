namespace SiparisYonetimi.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik migration özelliğini aç
            AutomaticMigrationDataLossAllowed = true; // migration işlemlerinde data kayıpalrına izin ver
        }

        protected override void Seed(DatabaseContext context)
        {
           // BU metot veritabanı oluşturulduktan sonra çalışır ve tablo lara örnek kayıt ekleyebilmemizi sağlar.
           if(!context.Users.Any()) // Eğer veritabanında hiç kayıt yoksa
            {
                context.Users.Add(new Entities.User // Yeni bir kullanıcı oluştur
                {
                    CreateDate = DateTime.Now,
                    Email = "admin@SiparisYonetimi.net",
                    Id = 1,
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Username = "Admin",
                    Password = "123"

                });
                context.SaveChanges(); // Değişiklkleri veritabanına işle
            }
        }
    }
}
