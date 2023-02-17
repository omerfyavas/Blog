using AutoMapper;
using OmerBlog.Entity.DTOs.Categories;
using OmerBlog.Entity.Entities;
namespace OmerBlog.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category >().ReverseMap();
        }
    }
}
