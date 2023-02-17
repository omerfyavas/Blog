using OmerBlog.Data.UnitOfWorks;
using AutoMapper;
using OmerBlog.Entity.DTOs.Articles;
using OmerBlog.Entity.Entities;
using OmerBlog.Service.Services.Abstractions;

namespace OmerBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted, x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map; 
        }
    }
}
