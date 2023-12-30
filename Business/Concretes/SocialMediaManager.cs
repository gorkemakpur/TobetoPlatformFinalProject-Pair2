using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.SocialMedia.Request;
using Business.Dtos.SocialMedia.Response;
using Business.Dtos.SocialMedia.Request;
using Business.Dtos.SocialMedia.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        private readonly IMapper _mapper;

        public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper)
        {
            _socialMediaDal = socialMediaDal;
            _mapper = mapper;
        }
        public async Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest)
        {
            //socialMedia türünde bir nesne oluştur mapper içerisinde createsocialMediarequesti SocialMedia'e maple değeri değişkene ata 
            SocialMedia addSocialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);

            //bir response değişkeni oluştur            yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            SocialMedia createdSocialMedia = await _socialMediaDal.AddAsync(addSocialMedia);

            //son olarak request ile response'u maple
            CreatedSocialMediaResponse createdSocialMediaResponse = _mapper.Map<CreatedSocialMediaResponse>(createdSocialMedia);
            return createdSocialMediaResponse;
        }

        public async Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest)
        {
            SocialMedia removeSocialMedia = await _socialMediaDal.GetAsync(predicate: a => a.Id == deleteSocialMediaRequest.Id);

            await _socialMediaDal.DeleteAsync(removeSocialMedia);

            DeletedSocialMediaResponse deletedSocialMediaResponse = _mapper.Map<DeletedSocialMediaResponse>(deleteSocialMediaRequest);

            return deletedSocialMediaResponse;
        }

        //girilen id deki değer
        public async Task<GetByIdSocialMediaResponse> GetByIdAsync(Guid id)
        {
            var data = await _socialMediaDal.GetAsync(
                predicate: p => p.Id == id)
               ;

            var result = _mapper.Map<GetByIdSocialMediaResponse>(data);
            return result;
        }

        //Tüm veriler
        public async Task<IPaginate<GetListSocialMediaResponse>> GetListAsync(PageRequest pageRequest)
        {
            //bağlantılı kısımları göstermek için include kullanıyoruz
            //burada diğer tablodaki kısımı alamadım
            var data = await _socialMediaDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListSocialMediaResponse>>(data);
            return result;
        }

        public async Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            //bu kısıma bakılacak eksiklik var bütün değerleri girmeden istediğimiz değer ile update etme kısmına bakılacak
            SocialMedia updateSocialMedia = await _socialMediaDal.GetAsync(predicate: p => p.Id == updateSocialMediaRequest.Id);

            _mapper.Map(updateSocialMediaRequest, updateSocialMedia);

            SocialMedia updatedSocialMedia = await _socialMediaDal.UpdateAsync(updateSocialMedia);

            UpdatedSocialMediaResponse updatedSocialMediaResponse = _mapper.Map<UpdatedSocialMediaResponse>(updatedSocialMedia);

            return updatedSocialMediaResponse;
        }
    }

}
