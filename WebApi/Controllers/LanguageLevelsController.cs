using Business.Abstracts;
using Business.Dtos.LanguageLevel.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LanguageLevelsController : BaseController
    {
        ILanguageLevelService _languageLevelService;

        public LanguageLevelsController(ILanguageLevelService languageLevelService)
        {
            _languageLevelService = languageLevelService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageLevelRequest DeleteLanguageLevelRequest)
        {
            var result = await _languageLevelService.DeleteAsync(DeleteLanguageLevelRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            var result = await _languageLevelService.AddAsync(createLanguageLevelRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _languageLevelService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _languageLevelService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateLanguageLevelRequest updateLanguageLevelRequest)
        {
            var result = await _languageLevelService.UpdateAsync(updateLanguageLevelRequest);
            return Ok(result);
        }
    }

}
