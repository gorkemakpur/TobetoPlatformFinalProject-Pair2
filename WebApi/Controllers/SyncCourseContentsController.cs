using Business.Abstracts;
using Business.Dtos.AsyncCourseContent.Request;
using Business.Dtos.SyncCourseContent.Request;
using Business.Dtos.SyncCourseContent.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class SyncCourseContentsController : BaseController
    {
        ISyncCourseContentService _syncCourseContentService;

        public SyncCourseContentsController(ISyncCourseContentService syncCourseContentService)
        {
            _syncCourseContentService = syncCourseContentService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSyncCourseContentRequest DeleteSyncCourseContentRequest)
        {
            var result = await _syncCourseContentService.DeleteAsync(DeleteSyncCourseContentRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSyncCourseContentRequest createSyncCourseContentRequest)
        {
            var result = await _syncCourseContentService.AddAsync(createSyncCourseContentRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
           var result= await _syncCourseContentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _syncCourseContentService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSyncCourseContentRequest updateSyncCourseContentRequest)
        {
            var result = await _syncCourseContentService.UpdateAsync(updateSyncCourseContentRequest);
            return Ok(result);
        }
    }
}
