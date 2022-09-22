using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Business.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new() // T claas olamalı IEntity olmalı new lenebilmeli
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet; // <T> yazarak dbSet i kullanıma açmıış olduk
        public Repository()
        {
            if (_context == null) // Eğer yukarıda tanımladığımız _context nesnesi boşsa
            {
                _context = new DatabaseContext(); // context i doldur
                _dbSet = _context.Set<T>(); // yukarıda tanımladığımız dbSet i parametreyle gelen class a göre ayarla
            }
            
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity); 
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).FirstOrDefault(); 
        }

        public List<T> GetAll()
        {
           return _dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }

        public int SaveChanges() // bunu biz yazdık save de yazıp geçebiliriz
        {
            return _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
