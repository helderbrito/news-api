using ListArticles.Domain.Entities;

namespace ListArticles.Domain.Interfaces
{
    public interface IArticleRepository
    {
        List<Article> GetArticles();
    }
}