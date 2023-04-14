using AutoMapper;
using ListArticles.Application.DTOs;
using ListArticles.Application.Interfaces;
using ListArticles.Domain.Interfaces;

namespace ListArticles.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public List<ArticleDTO> GetArticles()
        {
            var articles = _articleRepository.GetArticles();
            var articleDTOs = new List<ArticleDTO>();

            foreach (var article in articles)
            {
                var articleDTO = _mapper.Map<ArticleDTO>(article);
                articleDTOs.Add(articleDTO);
            }

            return articleDTOs;
        }
    }
}