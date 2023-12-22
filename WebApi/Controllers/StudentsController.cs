using Business.Abstracts;
using Business.Dtos.Student.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class StudentsController : BaseController
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateStudentRequest createStudentRequest)
        {
            var result = await _studentService.AddAsync(createStudentRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateStudentRequest updateStudentRequest)
        {
            var result = await _studentService.UpdateAsync(updateStudentRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteStudentRequest deleteStudentRequest)
        {
            var result = await _studentService.DeleteAsync(deleteStudentRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _studentService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
