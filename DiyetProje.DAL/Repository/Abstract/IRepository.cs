using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Repository.Abstract
{
    public interface IRepository<T> // Tüm repository sınıflarının implement etmesi gereken genel veri erişim metotlarını tanımlar. (CRUD)
    {
        public void Insert(T entity); 
        public void Update(T entity);
        public void Delete(T entity); 
        public void Remove(T entity); 
        public IQueryable<T> GetAll();
        public T GetById(int id); 
        public IQueryable<T> Search(Expression<Func<T, bool>> predicate); 
        public T GetDeletedById(int id);
        public IQueryable<T> GetAllDeleted();
        public IQueryable<T> GetAllWithIncludes(); 
        public IQueryable<T> GetAllWithIncludes(params string[] navigationProps); 
        public IQueryable<T> SearchWithIncludes(Expression<Func<T, bool>> predicate);
    }
}
