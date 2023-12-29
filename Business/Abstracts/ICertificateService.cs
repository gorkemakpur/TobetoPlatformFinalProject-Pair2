using Business.Dtos.Certificate.Request;
using Business.Dtos.Certificate.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICertificateService
    {
        Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest);
        Task<DeletedCertificateResponse> DeleteAsync(DeleteCertificateRequest deleteCertificateRequest);
        Task<UpdatedCertificateResponse> UpdateAsync(UpdateCertificateRequest updateCertificateRequest);
        Task<IPaginate<GetListCertificateResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdCertificateResponse> GetByIdAsync(Guid id);
    }

}
