using Business.Abstracts;
using Business.Dtos.User.Request;
using Business.Dtos.Application.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UsersController : BaseController
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserRequest DeleteUserRequest)
        {
            var result = await _userService.DeleteAsync(DeleteUserRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserRequest createUserRequest)
        {
            var result = await _userService.AddAsync(createUserRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _userService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _userService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByMail([FromQuery] string email)
        {
            var result = await _userService.GetByMailAsync(email);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByMail([FromQuery] string email)
        {
            var result = await _userService.GetByMailAsync(email);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateUserRequest updateUserRequest)
        {
            var result = await _userService.UpdateAsync(updateUserRequest);
            return Ok(result);
        }
    
}

}
