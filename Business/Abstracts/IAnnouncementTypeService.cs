using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAnnouncementTypeService
    {
        Task<CreatedAnnouncementTypeResponse> Add(CreateAnnouncementTypeRequest createAnnouncementTypeRequest);
        Task<IPaginate<GetListAnnouncementTypeResponse>> GetList(PageRequest pageRequest);
    }

}
