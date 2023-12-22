using Business.Abstracts;
using Business.Dtos.Situation.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SituationsController : BaseController
    {
        ISituationService _situationService;

        public SituationsController(ISituationService situationService)
        {
            _situationService = situationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSituationRequest createSituationRequest)
        {
            var result = await _situationService.AddAsync(createSituationRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSituationRequest updateSituationRequest)
        {
            var result = await _situationService.UpdateAsync(updateSituationRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSituationRequest deleteSituationRequest)
        {
            var result = await _situationService.DeleteAsync(deleteSituationRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _situationService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _situationService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
