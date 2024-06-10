using AutoMapper;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Mapping
{
    public class SocialMediaMapper : Profile
    {
        public SocialMediaMapper() 
        {
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();    
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
