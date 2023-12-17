using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAnnouncementService
    {
        Task<CreatedAnnouncementResponse> Add(CreateAnnouncementRequest createAnnouncementRequest);
        Task<DeletedAnnouncementResponse> Delete(DeleteAnnouncementRequest deleteAnnouncementRequest);
        Task<UpdatedAnnouncementResponse> Update(UpdateAnnouncementRequest updateAnnouncementRequest);
        Task<IPaginate<GetListAnnouncementResponse>> GetList(PageRequest pageRequest);
        Task<GetByIdAnnouncementResponse> GetById(Guid id);
    }
}
