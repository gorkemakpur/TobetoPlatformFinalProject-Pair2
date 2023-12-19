using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AnnouncementTypeManager : IAnnouncementTypeService
    {
        private readonly IAnnouncementTypeDal _announcementTypeDal;
        private readonly IMapper _mapper;

        public AnnouncementTypeManager(IAnnouncementTypeDal announcementTypeDal, IMapper mapper)
        {
            _announcementTypeDal = announcementTypeDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementTypeResponse> AddAsync(CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            AnnouncementType addAnnouncementType = _mapper.Map<AnnouncementType>(createAnnouncementTypeRequest);
            AnnouncementType createdAnnouncementType = await _announcementTypeDal.AddAsync(addAnnouncementType);
            CreatedAnnouncementTypeResponse createdAnnouncementTypeResponse = _mapper.Map<CreatedAnnouncementTypeResponse>(createdAnnouncementType);
            return createdAnnouncementTypeResponse;
        }

        public async Task<DeletedAnnouncementTypeResponse> DeleteAsync(DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest)
        {
            AnnouncementType removeAnnouncementType = await _announcementTypeDal.GetAsync(predicate: at =>at.Id==deleteAnnouncementTypeRequest.Id);

            await _announcementTypeDal.DeleteAsync(removeAnnouncementType);

            DeletedAnnouncementTypeResponse deletedAnnouncementTypeResponse = _mapper.Map<DeletedAnnouncementTypeResponse>(deleteAnnouncementTypeRequest);//bu kısıma tekrar bakılacak
            return deletedAnnouncementTypeResponse;
        }

        public async Task<GetByIdAnnouncementTypeResponse> GetByIdAsync(Guid id)
        {
            AnnouncementType result = await _announcementTypeDal.GetAsync(at => at.Id == id);//gelen veri announcementtype tipinde
            GetByIdAnnouncementTypeResponse data = _mapper.Map<GetByIdAnnouncementTypeResponse>(result); //onu burada response türüne map ediyoruz sonra return ediyoruz
            return data;
        }

        public async Task<IPaginate<GetListAnnouncementTypeResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _announcementTypeDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAnnouncementTypeResponse>>(data);
            return result;
        }

        public async Task<UpdatedAnnouncementTypeResponse> UpdateAsync(UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest)
        {
            AnnouncementType updateAnnouncementType = await _announcementTypeDal.GetAsync(p => p.Id == updateAnnouncementTypeRequest.Id);

            _mapper.Map(updateAnnouncementTypeRequest, updateAnnouncementType);

            AnnouncementType updatedAnnouncementType = await _announcementTypeDal.UpdateAsync(updateAnnouncementType);

            UpdatedAnnouncementTypeResponse updatedAnnouncementTypeResponse = _mapper.Map<UpdatedAnnouncementTypeResponse>(updatedAnnouncementType);

            return updatedAnnouncementTypeResponse;
        }
    
    }


}
