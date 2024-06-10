using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping() 
        { 
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
