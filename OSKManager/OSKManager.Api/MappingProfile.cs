using AutoMapper;
using OSKManager.Api.Models;
using OSKManager.Model;

namespace OSKManager.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterModel, Student>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}