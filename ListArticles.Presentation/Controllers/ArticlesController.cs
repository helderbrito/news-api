using ListArticles.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ListArticles.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var articles = _articleService.GetArticles();

            return Ok(articles);
        }
    }
}