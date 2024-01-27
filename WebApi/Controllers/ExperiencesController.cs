using Business.Abstracts;
using Business.Dtos.Experience.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ExperiencesController : BaseController
    {
        IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteExperienceRequest DeleteExperienceRequest)
        {
            var result = await _experienceService.DeleteAsync(DeleteExperienceRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.AddAsync(createExperienceRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _experienceService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _experienceService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateExperienceRequest updateExperienceRequest)
        {
            var result = await _experienceService.UpdateAsync(updateExperienceRequest);
            return Ok(result);
        }
    }


}
