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
    public class CategoryManager : Manager<CategoryViewModel,Category,CategoryMappingProfile>
    {
        public CategoryManager()
        {
            _repository = new CategoryRepository(new DiyetDbContext());
        }
    }
}
