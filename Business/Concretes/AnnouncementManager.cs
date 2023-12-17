using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AnnouncementType.Response;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        private readonly IMapper _mapper;

        public AnnouncementManager(IAnnouncementDal announcementDal, IMapper mapper)
        {
            _announcementDal = announcementDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementResponse> Add(CreateAnnouncementRequest createAnnouncementRequest)
        {
            //announcement türünde bir nesne oluştur mapper içerisinde createannouncementrequesti Announcement'e maple değeri değişkene ata 
            Announcement addAnnouncement = _mapper.Map<Announcement>(createAnnouncementRequest);
            //bir response değişkeni oluştur           yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            Announcement createdAnnouncementResponse = await _announcementDal.AddAsync(addAnnouncement);
            //son olarak request ile response'u maple
            CreatedAnnouncementResponse createdAnnouncement = _mapper.Map<CreatedAnnouncementResponse>(createdAnnouncementResponse);
            return createdAnnouncement;
        }

        public async Task<IPaginate<GetListAnnouncementResponse>> GetList(PageRequest pageRequest)
        {
            var data = await _announcementDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAnnouncementResponse>>(data);
            return result;
        }
    }


}
