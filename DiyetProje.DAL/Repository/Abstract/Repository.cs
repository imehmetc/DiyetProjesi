using DiyetProje.DAL.Context;
using DiyetProje.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly DiyetDbContext _context;
        private DbSet<T> entities;
        protected Repository(DiyetDbContext db)
        {
            _context = db;
            entities = _context.Set<T>();
        }
        public void Delete(T entity)
        {
            entity.Status = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;

            Update(entity);
        }
        public void Update(T entity)
        {
            entity.CreatedDate = entities.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id).CreatedDate;

            if (entity.Status != DataStatus.Deleted)
            {
                entity.Status = DataStatus.Modified;
                entity.ModifiedDate = DateTime.Now;
            }

            var existingEntity = entities.Local.FirstOrDefault(e => e.Id == entity.Id);

            if (existingEntity != null)
            {
                entities.Entry(existingEntity).CurrentValues.SetValues(entity);
            }
            else
            {
                entities.Update(entity);
            }

            _context.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return entities.AsNoTracking().Where(e => e.Status != DataStatus.Deleted);
        }

        public IQueryable<T> GetAllDeleted()
        {
            return entities.AsNoTracking().Where(e => e.Status == DataStatus.Deleted);
        }

        public IQueryable<T> GetAllWithIncludes()
        {
            IQueryable<T> query = GetAll();

            T instance = new T();
            Type type = instance.GetType();

            PropertyInfo[] propertyInfos = type.GetProperties();

            var props = propertyInfos.Where(pi =>
            pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name ==
            "ICollection").Any()).ToList();
            foreach (PropertyInfo propInfo in props)
            {
                if (propInfo.PropertyType.GetInterfaces().Any(i => i.Name == "ICollection"))
                {
                    var elementType =
                    propInfo.PropertyType.GetGenericArguments().FirstOrDefault().BaseType.Name;
                    if (elementType == "BaseEntity")
                        query = query.Include(propInfo.Name);
                }
                else
                    query = query.Include(propInfo.Name);
            }
            return query;
        }

        public IQueryable<T> GetAllWithIncludes(params string[] navigationProps)
        {
            IQueryable<T> query = GetAll();

            foreach (var item in navigationProps)
            {
                query = query.Include(item);
            }

            return query;
        }

        public T GetById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Status != DataStatus.Deleted);
        }

        public T GetDeletedById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Status == DataStatus.Deleted);
        }

        public void Insert(T entity)
        {
            entity.Status = DataStatus.Added;
            entity.CreatedDate = DateTime.Now;
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var constraint = entities.Where(e => e.Status != DataStatus.Deleted);
            return constraint.Where(predicate);
        }

        public IQueryable<T> SearchWithIncludes(Expression<Func<T, bool>> predicate)
        {
            var all = Search(predicate);

            T instance = new T();
            Type? type = instance.GetType();

            PropertyInfo[] props = type.GetProperties();

            foreach (var item in props.Where(x => x.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "IList").Any()).ToList())
            {
                all = all.Include(item.Name);
            }

            return all;
        }
    }
}
