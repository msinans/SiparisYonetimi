using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Business.Managers
{
    public class UserManager // klavyeden igili class ı çift tıklayıp f12 tuşu ile direkt gidebiliriz
    {
        DatabaseContext context = new DatabaseContext(); // Repository Pattern ile aynı kodları diğer class lara tekrar yazmadan uygulayabiliyorum
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
        public List<User> GetAll(string kelime)
        {
            return context.Users.Where(user=>user.Name.Contains(kelime) || user.Surname.Contains(kelime)).ToList(); // her kolon içn veya ile arama yaptırılabilir
        }
        public int Add(User user)
        {
            context.Users.Add(user); // context e gelen user ı ekliyor
            return context.SaveChanges(); // context teki değişiklikleri kaydet
        }
        public User Find(int id)
        {
            return context.Users.Find(id);
        }
        public int Update(User user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }
        public int Remove(User user)
        {
            context.Users.Remove(user);
            return context.SaveChanges();
        }
    }
}
