using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.Instructor.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    public class AnnouncementTypesController : BaseController
    {
        IAnnouncementTypeService _announcementTypeService;

        public AnnouncementTypesController(IAnnouncementTypeService announcementTypeService)
        {
            _announcementTypeService = announcementTypeService;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.AddAsync(createAnnouncementTypeRequest);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.UpdateAsync(updateAnnouncementTypeRequest);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.DeleteAsync(deleteAnnouncementTypeRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementTypeService.GetListAsync(pageRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _announcementTypeService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
