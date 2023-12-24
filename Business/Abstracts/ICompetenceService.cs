using Business.Dtos.Competence.Request;
using Business.Dtos.Competence.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICompetenceService
    {
        Task<CreatedCompetenceResponse> AddAsync(CreateCompetenceRequest createCompetenceRequest);
        Task<DeletedCompetenceResponse> DeleteAsync(DeleteCompetenceRequest deleteCompetenceRequest);
        Task<UpdatedCompetenceResponse> UpdateAsync(UpdateCompetenceRequest updateCompetenceRequest);
        Task<IPaginate<GetListCompetenceResponse>> GetListAsync();
        Task<GetByIdCompetenceResponse> GetByIdAsync(Guid id);
    }
}
