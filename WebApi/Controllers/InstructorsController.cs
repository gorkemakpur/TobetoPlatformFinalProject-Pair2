using Business.Abstracts;
using Business.Dtos.Instructor.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class InstructorsController : BaseController
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteInstructorRequest DeleteInstructorRequest)
        {
            var result = await _instructorService.DeleteAsync(DeleteInstructorRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            var result = await _instructorService.AddAsync(createInstructorRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _instructorService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateInstructorRequest updateInstructorRequest)
        {
            var result = await _instructorService.UpdateAsync(updateInstructorRequest);
            return Ok(result);
        }
    }


}
