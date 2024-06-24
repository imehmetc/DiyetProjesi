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
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<ProductViewModel, Product>().ForMember(x => x.Category, b => b.MapFrom(x => x.Category)).ReverseMap();
        }
    }
}
