using DiyetProje.DAL.Context;
using DiyetProje.DAL.Entities;
using DiyetProje.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.DAL.Repository.Concrete
{
    public class MealRepository : Repository<Meal>
    {
        public MealRepository(DiyetDbContext db) : base(db)
        {
            
        }
    }
}
