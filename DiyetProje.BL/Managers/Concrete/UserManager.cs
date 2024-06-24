using DiyetProje.BL.Managers.Abstract;
using DiyetProje.BL.MappingProfiles;
using DiyetProje.BL.Models;
using DiyetProje.DAL.Context;
using DiyetProje.DAL.Entities;
using DiyetProje.DAL.Repository.Abstract;
using DiyetProje.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.Managers.Concrete
{
    public class UserManager:Manager<UserViewModel,User,UserMappingProfile>
    {
        public UserManager()
        {
            _repository = new UserRepository(new DiyetDbContext());
        }
    }
}
