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
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>().ForMember(x => x.Products, b => b.MapFrom(x => x.Products)).ReverseMap();
            CreateMap<UserMealProductViewModel, UserMealProduct>().ForMember(x => x.Product, b => b.MapFrom(x => x.Product)).ReverseMap();
        }
    }
}
