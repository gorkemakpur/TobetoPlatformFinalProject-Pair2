using Business.Abstracts;
using Business.Dtos.Language.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LanguagesController : BaseController
    {
        ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLanguageRequest createLanguageRequest)
        {
            var result = await _languageService.AddAsync(createLanguageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateLanguageRequest updateLanguageRequest)
        {
            var result = await _languageService.UpdateAsync(updateLanguageRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageRequest deleteLanguageRequest)
        {
            var result = await _languageService.DeleteAsync(deleteLanguageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _languageService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
