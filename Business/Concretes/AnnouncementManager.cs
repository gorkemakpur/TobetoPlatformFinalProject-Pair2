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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Security.Cryptography.X509Certificates;

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

        public async Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest)
        {
            //announcement türünde bir nesne oluştur mapper içerisinde createannouncementrequesti Announcement'e maple değeri değişkene ata 
            Announcement addAnnouncement = _mapper.Map<Announcement>(createAnnouncementRequest);
            //bir response değişkeni oluştur           yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            Announcement createdAnnouncementResponse = await _announcementDal.AddAsync(addAnnouncement);
            //son olarak request ile response'u maple
            CreatedAnnouncementResponse createdAnnouncement = _mapper.Map<CreatedAnnouncementResponse>(createdAnnouncementResponse);
            return createdAnnouncement;
        }

        public async Task<DeletedAnnouncementResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest)
        {
            Announcement removeAnnouncement = await _announcementDal.GetAsync(predicate: a => a.Id == deleteAnnouncementRequest.Id);
            await _announcementDal.DeleteAsync(removeAnnouncement);
            DeletedAnnouncementResponse deletedAnnouncementResponse = _mapper.Map<DeletedAnnouncementResponse>(deleteAnnouncementRequest);
            return deletedAnnouncementResponse;
        }

        //girilen id deki değer
        public async Task<GetByIdAnnouncementResponse> GetByIdAsync(Guid id)
        {
            var data = await _announcementDal.GetAsync(predicate: p => p.Id == id,
                include: p => p.Include(p => p.AnnouncementType));

            var result = _mapper.Map<GetByIdAnnouncementResponse>(data);
            return result;
        }

        //Tüm veriler
        public async Task<IPaginate<GetListAnnouncementResponse>> GetListAsync(PageRequest pageRequest)
        {
            //bağlantılı kısımları göstermek için include kullanıyoruz
            //burada diğer tablodaki kısımı alamadım
            var data = await _announcementDal.GetListAsync(include: p => p.Include(p => p.AnnouncementType),
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAnnouncementResponse>>(data);
            return result;
        }

        public async Task<UpdatedAnnouncementResponse> UpdateAsync(UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            //bu kısıma bakılacak eksiklik var bütün değerleri girmeden istediğimiz değer ile update etme kısmına bakılacak
            Announcement updateAnnouncement = await _announcementDal.GetAsync(p => p.Id == updateAnnouncementRequest.Id);
            _mapper.Map(updateAnnouncementRequest, updateAnnouncement);
            Announcement updatedAnnouncement = await _announcementDal.UpdateAsync(updateAnnouncement);
            UpdatedAnnouncementResponse updatedAnnouncementResponse = _mapper.Map<UpdatedAnnouncementResponse>(updatedAnnouncement);

            return updatedAnnouncementResponse;
        }
    }


}
