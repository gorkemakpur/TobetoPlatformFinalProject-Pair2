using Business.Abstracts;
using Business.Dtos.LanguageType.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LanguageTypesController : BaseController
    {
        ILanguageTypeService _languageTypeService;

        public LanguageTypesController(ILanguageTypeService languageTypeService)
        {
            _languageTypeService = languageTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLanguageTypeRequest createLanguageTypeRequest)
        {
            var result = await _languageTypeService.AddAsync(createLanguageTypeRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateLanguageTypeRequest updateLanguageTypeRequest)
        {
            var result = await _languageTypeService.UpdateAsync(updateLanguageTypeRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageTypeRequest deleteLanguageTypeRequest)
        {
            var result = await _languageTypeService.DeleteAsync(deleteLanguageTypeRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageTypeService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _languageTypeService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
