using AutoMapper;
using Common;
using DAL.Models;

namespace BLL.MappingProfiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();
        }
    }
}
