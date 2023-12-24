using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.Application.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ApplicationsController : BaseController
    {
        IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateApplicationRequest createApplicationRequest)
        {
            var result = await _applicationService.AddAsync(createApplicationRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateApplicationRequest updateApplicationRequest)
        {
            var result = await _applicationService.UpdateAsync(updateApplicationRequest);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteApplicationRequest deleteApplicationRequest)
        {
            var result = await _applicationService.DeleteAsync(deleteApplicationRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _applicationService.GetListAsync(pageRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _applicationService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
