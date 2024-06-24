using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DiyetProje.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Managers.Abstract
{
    public abstract class Manager<TModel, TEntity, TMapperProfile> : IManager<TModel> where TMapperProfile:Profile,new()
    {
        private IMapper _mapper;

        protected IRepository<TEntity> _repository; 
        private MapperConfiguration _config;

        public Manager()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap(); 
   
                cfg.AddProfile<TMapperProfile>();
            });
            _mapper = new Mapper(_config);
        }

      
        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); 
            _repository.Delete(entity); 
        }

        public List<TModel> GetAll()
        {  
            List<TEntity> entities = _repository.GetAll().ToList(); // IQueryable tipte geldiği için List'e çevrilir.
    
            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id); 
            TModel model = _mapper.Map<TModel>(entity); 
            return model; 
        }

        public void Insert(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); 
            _repository.Insert(entity); 
        }

        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model); 
            _repository.Remove(entity); 
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {   
            Expression<Func<TEntity, bool>> entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
        
            List<TEntity> entities = _repository.Search(entityPredicate).ToList(); 
 
            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);  
            _repository.Update(entity); 
        }

        public TModel GetDeletedById(int id)
        {
            TEntity entity = _repository.GetDeletedById(id); 
            TModel model = _mapper.Map<TModel>(entity); 
            return model; 
        }

        public List<TModel> GetAllDeleted()
        {
           
            List<TEntity> entities = _repository.GetAllDeleted().ToList(); // IQueryable tipte geldiği için List'e çevrilir.
      
            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithIncludes()
        {
            List<TEntity> entities = _repository.GetAllWithIncludes().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithIncludes(params string[] navigationProps)
        {
            List<TEntity> entities = _repository.GetAllWithIncludes(navigationProps).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> SearchWithIncludes(Expression<Func<TModel, bool>> predicate)
        {
 
            Expression<Func<TEntity, bool>> entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
  
            List<TEntity> entities = _repository.SearchWithIncludes(entityPredicate).ToList(); 
  
            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }
    }
}