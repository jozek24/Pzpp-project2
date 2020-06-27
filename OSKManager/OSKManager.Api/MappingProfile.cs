using AutoMapper;
using OSKManager.Api.Models;
using OSKManager.Model;

namespace OSKManager.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterModel, Administrator>()
                .ForMember(u => u.UserName,
                    opt => opt.MapFrom(x => x.Email));
            CreateMap<RegisterModel, Instructor>()
                .ForMember(u => u.UserName,
                    opt => opt.MapFrom(x => x.Email));
            CreateMap<RegisterModel, Student>()
                .ForMember(u => u.UserName,
                    opt => opt.MapFrom(x => x.Email));
        }
    }
}