using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        IAnnouncementService _announcementService;

        public AnnouncementsController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementRequest DeleteAnnouncementRequest)
        {
            var result = await _announcementService.Delete(DeleteAnnouncementRequest);
            return Ok(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementRequest createAnnouncementRequest)
        {
            var result = await _announcementService.Add(createAnnouncementRequest);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery]Guid id)
        {
            var result = await _announcementService.GetById(id);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            var result = await _announcementService.Update(updateAnnouncementRequest);
            return Ok(result);
        }
    }
}
