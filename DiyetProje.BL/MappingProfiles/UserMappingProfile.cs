using AutoMapper;
using DiyetProje.BL.Models;
using DiyetProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProje.BL.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserMealProductViewModel, UserMealProduct>().ForMember(x => x.User, b => b.MapFrom(x => x.User)).ReverseMap();
        }
    }
}
