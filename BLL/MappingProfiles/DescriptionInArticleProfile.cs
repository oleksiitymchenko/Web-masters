using AutoMapper;
using Common;
using DAL.Models;

namespace BLL.MappingProfiles
{
    public class DescriptionInArticleProfile : Profile
    {
        public DescriptionInArticleProfile()
        {
            CreateMap<DescriptionInArticle, DescriptionInArticleDto>();
            CreateMap<DescriptionInArticleDto, DescriptionInArticle>();
        }
    }
}
