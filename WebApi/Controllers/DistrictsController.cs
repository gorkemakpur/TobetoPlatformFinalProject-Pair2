using Business.Abstracts;
using Business.Dtos.District.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class DistrictsController : BaseController
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteDistrictRequest DeleteDistrictRequest)
        {
            var result = await _districtService.DeleteAsync(DeleteDistrictRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDistrictRequest createDistrictRequest)
        {
            var result = await _districtService.AddAsync(createDistrictRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _districtService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _districtService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateDistrictRequest updateDistrictRequest)
        {
            var result = await _districtService.UpdateAsync(updateDistrictRequest);
            return Ok(result);
        }
    }
}
