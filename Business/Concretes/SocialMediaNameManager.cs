using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SocialMediaName.Request;
using Business.Dtos.SocialMediaName.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SocialMediaNameManager : ISocialMediaNameService
    {
        private readonly ISocialMediaNameDal _socialMediaNameDal;
        private readonly IMapper _mapper;

        public SocialMediaNameManager(ISocialMediaNameDal socialMediaNameDal, IMapper mapper)
        {
            _socialMediaNameDal = socialMediaNameDal;
            _mapper = mapper;
        }

        public async Task<CreatedSocialMediaNameResponse> AddAsync(CreateSocialMediaNameRequest createSocialMediaNameRequest)
        {
            //socialMediaName türünde bir nesne oluştur mapper içerisinde createsocialMediaNamerequesti SocialMediaName'e maple değeri değişkene ata 
            SocialMediaName addSocialMediaName = _mapper.Map<SocialMediaName>(createSocialMediaNameRequest);

            //bir response değişkeni oluştur            yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            SocialMediaName createdSocialMediaName = await _socialMediaNameDal.AddAsync(addSocialMediaName);

            //son olarak request ile response'u maple
            CreatedSocialMediaNameResponse createdSocialMediaNameResponse = _mapper.Map<CreatedSocialMediaNameResponse>(createdSocialMediaName);
            return createdSocialMediaNameResponse;
        }

        public async Task<DeletedSocialMediaNameResponse> DeleteAsync(DeleteSocialMediaNameRequest deleteSocialMediaNameRequest)
        {
            SocialMediaName removeSocialMediaName = await _socialMediaNameDal.GetAsync(predicate: a => a.Id == deleteSocialMediaNameRequest.Id);

            await _socialMediaNameDal.DeleteAsync(removeSocialMediaName);

            DeletedSocialMediaNameResponse deletedSocialMediaNameResponse = _mapper.Map<DeletedSocialMediaNameResponse>(deleteSocialMediaNameRequest);

            return deletedSocialMediaNameResponse;
        }

        //girilen id deki değer
        public async Task<GetByIdSocialMediaNameResponse> GetByIdAsync(Guid id)
        {
            var data = await _socialMediaNameDal.GetAsync(
                predicate: p => p.Id == id)
               ;

            var result = _mapper.Map<GetByIdSocialMediaNameResponse>(data);
            return result;
        }

        //Tüm veriler
        public async Task<IPaginate<GetListSocialMediaNameResponse>> GetListAsync(PageRequest pageRequest)
        {
            //bağlantılı kısımları göstermek için include kullanıyoruz
            //burada diğer tablodaki kısımı alamadım
            var data = await _socialMediaNameDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListSocialMediaNameResponse>>(data);
            return result;
        }

        public async Task<UpdatedSocialMediaNameResponse> UpdateAsync(UpdateSocialMediaNameRequest updateSocialMediaNameRequest)
        {
            //bu kısıma bakılacak eksiklik var bütün değerleri girmeden istediğimiz değer ile update etme kısmına bakılacak
            SocialMediaName updateSocialMediaName = await _socialMediaNameDal.GetAsync(predicate: p => p.Id == updateSocialMediaNameRequest.Id);

            _mapper.Map(updateSocialMediaNameRequest, updateSocialMediaName);

            SocialMediaName updatedSocialMediaName = await _socialMediaNameDal.UpdateAsync(updateSocialMediaName);

            UpdatedSocialMediaNameResponse updatedSocialMediaNameResponse = _mapper.Map<UpdatedSocialMediaNameResponse>(updatedSocialMediaName);

            return updatedSocialMediaNameResponse;
        }
    }

}
