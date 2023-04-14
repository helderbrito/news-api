using ListArticles.Application.Interfaces;
using ListArticles.Application.Mappings;
using ListArticles.Application.Services;
using ListArticles.Domain.Interfaces;
using ListArticles.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ListArticles.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleService, ArticleService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}