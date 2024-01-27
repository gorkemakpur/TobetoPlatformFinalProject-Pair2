using Business.Abstracts;
using Business.Dtos.Competence.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //**
    public class CompetencesController : BaseController
    {
        ICompetenceService _competenceService;

        public CompetencesController(ICompetenceService competenceService)
        {
            _competenceService = competenceService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCompetenceRequest DeleteCompetenceRequest)
        {
            var result = await _competenceService.DeleteAsync(DeleteCompetenceRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCompetenceRequest createCompetenceRequest)
        {
            var result = await _competenceService.AddAsync(createCompetenceRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _competenceService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _competenceService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateCompetenceRequest updateCompetenceRequest)
        {
            var result = await _competenceService.UpdateAsync(updateCompetenceRequest);
            return Ok(result);
        }
    }

}
