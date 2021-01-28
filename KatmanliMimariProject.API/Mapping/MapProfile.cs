using AutoMapper;
using KatmanliMimariProject.API.DTOs;
using KatmanliMimariProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanliMimariProject.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<ProductWithCategoryDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
        }
    }
}
