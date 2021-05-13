using AutoMapper;
using Common;
using DAL.Models;

namespace BLL.MappingProfiles
{
    public class DescriptionProfile : Profile
    {
        public DescriptionProfile()
        {
            CreateMap<Description, DescriptionDto>();
            CreateMap<DescriptionDto, Description>();
        }
    }
}
