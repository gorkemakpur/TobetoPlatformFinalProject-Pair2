using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Application.Request;
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
    }
}
