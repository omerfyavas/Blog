using OmerBlog.Entity.DTOs.Articles;
using OmerBlog.Entity.Entities;

namespace OmerBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();
    }
}
