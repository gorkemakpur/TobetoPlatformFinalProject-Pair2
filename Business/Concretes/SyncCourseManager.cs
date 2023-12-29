using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SyncCourse.Request;
using Business.Dtos.SyncCourse.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SyncCourseManager : ISyncCourseService
    {
        private readonly ISyncCourseDal _syncCourseDal;
        private readonly IMapper _mapper;

        public SyncCourseManager(ISyncCourseDal syncCourseDal, IMapper mapper)
        {
            _syncCourseDal = syncCourseDal;
            _mapper = mapper;
        }

        public async Task<CreatedSyncCourseResponse> AddAsync(CreateSyncCourseRequest createSyncCourseRequest)
        {
            //syncCourse türünde bir nesne oluştur mapper içerisinde createsyncCourserequesti SyncCourse'e maple değeri değişkene ata 
            SyncCourse addSyncCourse = _mapper.Map<SyncCourse>(createSyncCourseRequest);

            //bir response değişkeni oluştur            yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            SyncCourse createdSyncCourse = await _syncCourseDal.AddAsync(addSyncCourse);

            //son olarak request ile response'u maple
            CreatedSyncCourseResponse createdSyncCourseResponse = _mapper.Map<CreatedSyncCourseResponse>(createdSyncCourse);
            return createdSyncCourseResponse;
        }

        public async Task<DeletedSyncCourseResponse> DeleteAsync(DeleteSyncCourseRequest deleteSyncCourseRequest)
        {
            SyncCourse removeSyncCourse = await _syncCourseDal.GetAsync(predicate: a => a.Id == deleteSyncCourseRequest.Id);

            await _syncCourseDal.DeleteAsync(removeSyncCourse);

            DeletedSyncCourseResponse deletedSyncCourseResponse = _mapper.Map<DeletedSyncCourseResponse>(deleteSyncCourseRequest);

            return deletedSyncCourseResponse;
        }

        //girilen id deki değer
        public async Task<GetByIdSyncCourseResponse> GetByIdAsync(Guid id)
        {
            var data = await _syncCourseDal.GetAsync(
                predicate: p => p.Id == id)
               ;

            var result = _mapper.Map<GetByIdSyncCourseResponse>(data);
            return result;
        }

        //Tüm veriler
        public async Task<IPaginate<GetListSyncCourseResponse>> GetListAsync(PageRequest pageRequest)
        {
            //bağlantılı kısımları göstermek için include kullanıyoruz
            //burada diğer tablodaki kısımı alamadım
            var data = await _syncCourseDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListSyncCourseResponse>>(data);
            return result;
        }

        public async Task<UpdatedSyncCourseResponse> UpdateAsync(UpdateSyncCourseRequest updateSyncCourseRequest)
        {
            //bu kısıma bakılacak eksiklik var bütün değerleri girmeden istediğimiz değer ile update etme kısmına bakılacak
            SyncCourse updateSyncCourse = await _syncCourseDal.GetAsync(predicate: p => p.Id == updateSyncCourseRequest.Id);

            _mapper.Map(updateSyncCourseRequest, updateSyncCourse);

            SyncCourse updatedSyncCourse = await _syncCourseDal.UpdateAsync(updateSyncCourse);

            UpdatedSyncCourseResponse updatedSyncCourseResponse = _mapper.Map<UpdatedSyncCourseResponse>(updatedSyncCourse);

            return updatedSyncCourseResponse;
        }
    }

}
