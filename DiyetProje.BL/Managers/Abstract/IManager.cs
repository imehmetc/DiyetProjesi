using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Managers.Abstract
{
    public interface IManager<TModel>
    {
        // DAL'daki asıl entity sınıflarını, BL'deki karşılığı olan ViewModel ile eşleştirip, ona göre Veritabanına ya da Veritabanından akışı sağlar.
        public void Insert(TModel entity);
        public void Update(TModel entity);
        public void Delete(TModel entity);
        public void Remove(TModel entity);
        public List<TModel> GetAll();
        public TModel GetById(int id);
        public List<TModel> Search(Expression<Func<TModel, bool>> predicate);
        public TModel GetDeletedById(int id);
        public List<TModel> GetAllDeleted();
        public List<TModel> GetAllWithIncludes();
        public List<TModel> GetAllWithIncludes(params string[] navigationProps);
        public List<TModel> SearchWithIncludes(Expression<Func<TModel, bool>> predicate);
    }
}
