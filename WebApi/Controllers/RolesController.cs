using Business.Abstracts;
using Business.Dtos.Role.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class RolesController : BaseController
    {
        IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateRoleRequest createRoleRequest)
        {
            var result = await _roleService.AddAsync(createRoleRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateRoleRequest updateRoleRequest)
        {
            var result = await _roleService.UpdateAsync(updateRoleRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteRoleRequest deleteRoleRequest)
        {
            var result = await _roleService.DeleteAsync(deleteRoleRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _roleService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _roleService.GetByIdAsync(id);
            return Ok(result);
        }

    }
}
