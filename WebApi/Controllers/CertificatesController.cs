using Business.Abstracts;
using Business.Dtos.Certificate.Request;
using Business.Dtos.Certificate.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class CertificatesController : BaseController
    {
        ICertificateService _certificateService;

        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCertificateRequest DeleteCertificateRequest)
        {
            var result = await _certificateService.DeleteAsync(DeleteCertificateRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCertificateRequest createCertificateRequest)
        {
            var result = await _certificateService.AddAsync(createCertificateRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _certificateService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _certificateService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateCertificateRequest updateCertificateRequest)
        {
            var result = await _certificateService.UpdateAsync(updateCertificateRequest);
            return Ok(result);
        }
    }
}
