using AutoMapper;
using ListArticles.Application.DTOs;
using ListArticles.Domain.Entities;

namespace ListArticles.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Article, ArticleDTO>().ReverseMap();
        }
    }
}