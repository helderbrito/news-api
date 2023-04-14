using ListArticles.Application.DTOs;

namespace ListArticles.Application.Interfaces
{
    public interface IArticleService
    {
        List<ArticleDTO> GetArticles();
    }
}