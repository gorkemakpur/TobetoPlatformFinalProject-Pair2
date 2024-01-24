using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IAnnouncementService
    {
        Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest);
        Task<DeletedAnnouncementResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest);
        Task<UpdatedAnnouncementResponse> UpdateAsync(UpdateAnnouncementRequest updateAnnouncementRequest);
        Task<IPaginate<GetListAnnouncementResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAnnouncementResponse> GetByIdAsync(Guid id);

        Task<Announcement> TransactionalOperation(Announcement announcement);
    }
}
