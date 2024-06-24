using DiyetProje.BL.Managers.Abstract;
using DiyetProje.BL.MappingProfiles;
using DiyetProje.BL.Models;
using DiyetProje.DAL.Context;
using DiyetProje.DAL.Entities;
using DiyetProje.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Managers.Concrete
{
    public class UserMealProductManager : Manager<UserMealProductViewModel, UserMealProduct, UserMealProductMappingProfile>
    {
            public UserMealProductManager()
            {
                _repository = new UserMealProductRepository(new DiyetDbContext());
            }
        }
}
