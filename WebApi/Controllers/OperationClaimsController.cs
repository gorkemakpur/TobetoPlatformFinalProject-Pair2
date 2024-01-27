using Business.Abstracts;
using Business.Dtos.OperationClaim.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class OperationClaimsController : BaseController
    {
        IOperationClaimService _operationClaimService;

        public OperationClaimsController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteOperationClaimRequest DeleteOperationClaimRequest)
        {
            var result = await _operationClaimService.DeleteAsync(DeleteOperationClaimRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateOperationClaimRequest createOperationClaimRequest)
        {
            var result = await _operationClaimService.AddAsync(createOperationClaimRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _operationClaimService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _operationClaimService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            var result = await _operationClaimService.UpdateAsync(updateOperationClaimRequest);
            return Ok(result);
        }
    }

}
