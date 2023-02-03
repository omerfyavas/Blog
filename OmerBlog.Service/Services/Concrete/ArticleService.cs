using OmerBlog.Data.UnitOfWorks;
using OmerBlog.Entity.Entities;
using OmerBlog.Service.Services.Abstractions;

namespace OmerBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
