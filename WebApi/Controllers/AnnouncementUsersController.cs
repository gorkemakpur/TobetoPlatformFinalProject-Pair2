using Business.Abstracts;
using Business.Dtos.AnnouncementUser.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AnnouncementUsersController : BaseController
{
    private readonly IAnnouncementUserService _AnnouncementUserService;

    public AnnouncementUsersController(IAnnouncementUserService AnnouncementUser)
    {
        _AnnouncementUserService = AnnouncementUser;
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementUserRequest DeleteAnnouncementUserRequest)
    {
        var result = await _AnnouncementUserService.DeleteAsync(DeleteAnnouncementUserRequest);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAnnouncementUserRequest createAnnouncementUserRequest)
    {
        var result = await _AnnouncementUserService.AddAsync(createAnnouncementUserRequest);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _AnnouncementUserService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        var result = await _AnnouncementUserService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Update([FromQuery] UpdateAnnouncementUserRequest updateAnnouncementUserRequest)
    {
        var result = await _AnnouncementUserService.UpdateAsync(updateAnnouncementUserRequest);
        return Ok(result);
    }
}