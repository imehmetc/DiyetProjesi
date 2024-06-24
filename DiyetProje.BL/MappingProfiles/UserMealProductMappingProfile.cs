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
    public class UserMealProductMappingProfile : Profile
    {
        public UserMealProductMappingProfile()
        {
            CreateMap<UserViewModel, User>().ForMember(x => x.UserMealProducts, b => b.MapFrom(x => x.UserMealProducts)).ReverseMap();
            CreateMap<ProductViewModel, Product>().ForMember(x => x.UserMealProducts, b => b.MapFrom(x => x.UserMealProducts)).ReverseMap();
            CreateMap<MealViewModel, Meal>().ForMember(x => x.UserMealProducts, b => b.MapFrom(x => x.UserMealProducts)).ReverseMap();
        }
    }
}
