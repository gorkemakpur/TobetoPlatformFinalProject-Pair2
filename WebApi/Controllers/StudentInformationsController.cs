using Business.Abstracts;
using Business.Dtos.StudentInformation.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class StudentInformationsController : BaseController
    {
        IStudentInformationService _studentInformationService;

        public StudentInformationsController(IStudentInformationService studentInformationService)
        {
            _studentInformationService = studentInformationService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteStudentInformationRequest DeleteStudentInformationRequest)
        {
            var result = await _studentInformationService.DeleteAsync(DeleteStudentInformationRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateStudentInformationRequest createStudentInformationRequest)
        {
            var result = await _studentInformationService.AddAsync(createStudentInformationRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentInformationService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _studentInformationService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentInformationRequest updateStudentInformationRequest)
        {
            var result = await _studentInformationService.UpdateAsync(updateStudentInformationRequest);
            return Ok(result);
        }

    }

}
