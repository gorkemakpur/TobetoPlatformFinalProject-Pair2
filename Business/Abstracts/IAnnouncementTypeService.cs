using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAnnouncementTypeService
    {
        Task<CreatedAnnouncementTypeResponse> AddAsync(CreateAnnouncementTypeRequest createAnnouncementTypeRequest);
        Task<UpdatedAnnouncementTypeResponse> UpdateAsync(UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest);
        Task<DeletedAnnouncementTypeResponse> DeleteAsync(DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest);
        Task<IPaginate<GetListAnnouncementTypeResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAnnouncementTypeResponse> GetByIdAsync(Guid id);
    }

  
}
