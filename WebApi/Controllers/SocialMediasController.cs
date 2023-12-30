using Business.Abstracts;
using Business.Dtos.SocialMedia.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SocialMediasController : BaseController
    {
        ISocialMediaService _socialMediaService;

        public SocialMediasController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSocialMediaRequest DeleteSocialMediaRequest)
        {
            var result = await _socialMediaService.DeleteAsync(DeleteSocialMediaRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaRequest createSocialMediaRequest)
        {
            var result = await _socialMediaService.AddAsync(createSocialMediaRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _socialMediaService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _socialMediaService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            var result = await _socialMediaService.UpdateAsync(updateSocialMediaRequest);
            return Ok(result);
        }

    }


}
