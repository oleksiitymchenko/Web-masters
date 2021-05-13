using AutoMapper;
using Common;
using DAL.Models;

namespace BLL.MappingProfiles
{
    public class ArticleInOrderProfile : Profile
    {
        public ArticleInOrderProfile()
        {
            CreateMap<ArticleInOrder, ArticleInOrderDto>();
            CreateMap<ArticleInOrderDto, ArticleInOrder>();
        }
    }
}
