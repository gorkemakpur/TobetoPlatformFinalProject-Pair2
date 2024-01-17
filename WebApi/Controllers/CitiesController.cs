using Business.Abstracts;
using Business.Dtos.City.Response;
using Business.Dtos.City.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class CitiesController : BaseController
    {
        ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCityRequest DeleteCityRequest)
        {
            var result = await _cityService.DeleteAsync(DeleteCityRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCityRequest createCityRequest)
        {
            var result = await _cityService.AddAsync(createCityRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _cityService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _cityService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateCityRequest updateCityRequest)
        {
            var result = await _cityService.UpdateAsync(updateCityRequest);
            return Ok(result);
        }
    }
}
