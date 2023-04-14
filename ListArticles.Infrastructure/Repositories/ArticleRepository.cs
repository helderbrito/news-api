using ListArticles.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace ListArticles.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly IConfiguration _configuration;

        public ArticleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Domain.Entities.Article> GetArticles()
        {
            string apiKey = _configuration["NewsApiKey"];

            NewsApiClient newsApiClient = new(apiKey);

            ArticlesResult articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = "business",
                SortBy = SortBys.Popularity,
                Language = Languages.BR
            });

            List<Domain.Entities.Article> articles = new();

            if (articlesResponse.Status == Statuses.Ok)
            {
                foreach (var article in articlesResponse.Articles)
                {
                    articles.Add(new Domain.Entities.Article
                    {
                        Author = article.Author,
                        Title = article.Title,
                        Description = article.Description,
                        Url = article.Url,
                        UrlToImage = article.UrlToImage,
                        PublishedAt = article.PublishedAt,
                        Content = article.Content,
                        Source = new Domain.Entities.Source
                        {
                            Id = article.Source.Id,
                            Name = article.Source.Name
                        }
                    });
                }
            }

            return articles;
        }
    }
}