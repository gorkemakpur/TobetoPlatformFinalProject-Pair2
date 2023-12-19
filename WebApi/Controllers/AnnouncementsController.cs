using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class AnnouncementsController : BaseController
    {
        IAnnouncementService _announcementService;

        public AnnouncementsController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementRequest DeleteAnnouncementRequest)
        {
            var result = await _announcementService.DeleteAsync(DeleteAnnouncementRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementRequest createAnnouncementRequest)
        {
            var result = await _announcementService.AddAsync(createAnnouncementRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery]Guid id)
        {
            var result = await _announcementService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            var result = await _announcementService.UpdateAsync(updateAnnouncementRequest);
            return Ok(result);
        }
    }
}
