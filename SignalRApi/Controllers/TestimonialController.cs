using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService TestimonialService, IMapper mapper)
        {
            _testimonialService = TestimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Name = createTestimonialDto.Name,
                Title = createTestimonialDto.Title,
                Comment = createTestimonialDto.Comment,
                ImageUrl = createTestimonialDto.ImageUrl,
                Status = createTestimonialDto.Status,
            });
            return Ok("İletişim bilgisi eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                Name = updateTestimonialDto.Name,
                Title = updateTestimonialDto.Title,
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Status = updateTestimonialDto.Status,
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
    }
}
