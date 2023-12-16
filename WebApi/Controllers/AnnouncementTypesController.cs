using Business.Abstracts;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.Instructor.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementTypesController : ControllerBase
    {
        IAnnouncementTypeService _announcementTypeService;

        public AnnouncementTypesController(IAnnouncementTypeService announcementTypeService)
        {
            _announcementTypeService = announcementTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.Add(createAnnouncementTypeRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementTypeService.GetList(pageRequest);
            return Ok(result);
        }

    }
}
