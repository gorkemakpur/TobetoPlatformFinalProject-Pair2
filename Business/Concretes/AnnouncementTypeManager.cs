using AutoMapper;
using Business.Abstracts;
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

        public async Task<CreatedAnnouncementTypeResponse> Add(CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            AnnouncementType addAnnouncementType = _mapper.Map<AnnouncementType>(createAnnouncementTypeRequest);
            AnnouncementType createdAnnouncementType  = await _announcementTypeDal.AddAsync(addAnnouncementType);
            CreatedAnnouncementTypeResponse createdAnnouncementTypeResponse = _mapper.Map<CreatedAnnouncementTypeResponse>(createdAnnouncementType);
            return createdAnnouncementTypeResponse;
        }

        public async Task<IPaginate<GetListAnnouncementTypeResponse>> GetList(PageRequest pageRequest)
        {
            var data = await _announcementTypeDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size:10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAnnouncementTypeResponse>>(data);
            return result;
        }
    }


}
