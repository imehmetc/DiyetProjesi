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
    public class MealMappingProfile : Profile
    {
        public MealMappingProfile()
        {
            CreateMap<UserMealProductViewModel, UserMealProduct>().ForMember(x => x.Meal, b => b.MapFrom(x => x.Meal)).ReverseMap();
        }
    }
}
