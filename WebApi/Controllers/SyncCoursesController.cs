using Business.Abstracts;
using Business.Dtos.SyncCourse.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SyncCoursesController : BaseController
    {
        ISyncCourseService _syncCourseService;

        public SyncCoursesController(ISyncCourseService syncCourseService)
        {
            _syncCourseService = syncCourseService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSyncCourseRequest DeleteSyncCourseRequest)
        {
            var result = await _syncCourseService.DeleteAsync(DeleteSyncCourseRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSyncCourseRequest createSyncCourseRequest)
        {
            var result = await _syncCourseService.AddAsync(createSyncCourseRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _syncCourseService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _syncCourseService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSyncCourseRequest updateSyncCourseRequest)
        {
            var result = await _syncCourseService.UpdateAsync(updateSyncCourseRequest);
            return Ok(result);
        }

    }

}
