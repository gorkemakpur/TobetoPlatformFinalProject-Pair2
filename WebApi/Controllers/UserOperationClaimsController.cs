using Business.Abstracts;
using Business.Dtos.UserOperationClaim.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UserOperationClaimsController : BaseController
    {
        IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimsController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserOperationClaimRequest DeleteUserOperationClaimRequest)
        {
            var result = await _userOperationClaimService.DeleteAsync(DeleteUserOperationClaimRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            var result = await _userOperationClaimService.AddAsync(createUserOperationClaimRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _userOperationClaimService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _userOperationClaimService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateUserOperationClaimRequest updateUserOperationClaimRequest)
        {
            var result = await _userOperationClaimService.UpdateAsync(updateUserOperationClaimRequest);
            return Ok(result);
        }
    }

}
