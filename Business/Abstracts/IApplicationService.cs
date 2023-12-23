using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.Application.Request;
using Business.Dtos.Application.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        Task<CreatedApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest);
        Task<DeletedApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest);
        Task<UpdatedApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest);
        Task<IPaginate<GetListApplicationResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdApplicationResponse> GetByIdAsync(Guid id);
    }

}
