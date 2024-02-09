using Business.Abstracts;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourseContent.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AsyncCourseContentsController : BaseController
    {
        IAsyncCourseContentService _asyncCourseContentService;

        public AsyncCourseContentsController(IAsyncCourseContentService asyncCourseContentService)
        {
            _asyncCourseContentService = asyncCourseContentService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAsyncCourseContentRequest createAsyncCourseContentRequest)
        {
            var result = await _asyncCourseContentService.AddAsync(createAsyncCourseContentRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateAsyncCourseContentRequest updateAsyncCourseContentRequest)
        {
            var result = await _asyncCourseContentService.UpdateAsync(updateAsyncCourseContentRequest);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAsyncCourseContentRequest deleteAsyncCourseContentRequest)
        {
            var result = await _asyncCourseContentService.DeleteAsync(deleteAsyncCourseContentRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _asyncCourseContentService.GetListAsync(pageRequest);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _asyncCourseContentService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByAsyncCourseId([FromQuery] Guid id)
        {
            var result = await _asyncCourseContentService.GetByAsynCourseId(id);
            return Ok(result);
        }
    }
}
