using Business.Abstracts;
using Business.Dtos.Application.Request;
using Business.Dtos.AsyncCourse.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AsyncCoursesController : BaseController
    {
        IAsyncCourseService _asyncCourseService;

        public AsyncCoursesController(IAsyncCourseService asyncCourseService)
        {
            _asyncCourseService = asyncCourseService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAsyncCourseRequest createAsyncCourseRequest)
        {
            var result = await _asyncCourseService.AddAsync(createAsyncCourseRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateAsyncCourseRequest updateAsyncCourseRequest)
        {
            var result = await _asyncCourseService.UpdateAsync(updateAsyncCourseRequest);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAsyncCourseRequest deleteAsyncCourseRequest)
        {
            var result = await _asyncCourseService.DeleteAsync(deleteAsyncCourseRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _asyncCourseService.GetListAsync(pageRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _asyncCourseService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
