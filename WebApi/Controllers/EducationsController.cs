using Business.Abstracts;
using Business.Dtos.Education.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class EducationsController : BaseController
    {
        IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteEducationRequest DeleteEducationRequest)
        {
            var result = await _educationService.DeleteAsync(DeleteEducationRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateEducationRequest createEducationRequest)
        {
            var result = await _educationService.AddAsync(createEducationRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _educationService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _educationService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateEducationRequest updateEducationRequest)
        {
            var result = await _educationService.UpdateAsync(updateEducationRequest);
            return Ok(result);
        }
    }
}
