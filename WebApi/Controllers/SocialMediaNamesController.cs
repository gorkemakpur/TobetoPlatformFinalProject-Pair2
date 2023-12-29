using Business.Abstracts;
using Business.Dtos.SocialMediaName.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SocialMediaNamesController : BaseController
    {
        ISocialMediaNameService _socialMediaNameService;

        public SocialMediaNamesController(ISocialMediaNameService socialMediaNameService)
        {
            _socialMediaNameService = socialMediaNameService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSocialMediaNameRequest DeleteSocialMediaNameRequest)
        {
            var result = await _socialMediaNameService.DeleteAsync(DeleteSocialMediaNameRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaNameRequest createSocialMediaNameRequest)
        {
            var result = await _socialMediaNameService.AddAsync(createSocialMediaNameRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _socialMediaNameService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _socialMediaNameService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSocialMediaNameRequest updateSocialMediaNameRequest)
        {
            var result = await _socialMediaNameService.UpdateAsync(updateSocialMediaNameRequest);
            return Ok(result);
        }

    }


}
