using OmerBlog.Entity.DTOs.Articles;

namespace OmerBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
     
    }
}
