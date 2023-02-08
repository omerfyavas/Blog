using AutoMapper;
using OmerBlog.Entity.DTOs.Articles;
using OmerBlog.Entity.Entities;

namespace OmerBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile

    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
        }

    }
}
