using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SiparisYonetimi.Business.Repositories
{
    public interface IRepository<T> // <T> kullanarak interface i generic hale getiriyoruz. Buradaki T dışarıdan parametre olarak gönderilecek class ları (brand, category, product, customer vb.) simgeler.
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Find(int id); // T yazarak bütün class lar için çalışmasını itiyoruz
        void Add(T entity); // void de yazsak olur int de olur
        void Update(T entity);
        void Delete(T entity);
        int SaveChanges();


    }
}
