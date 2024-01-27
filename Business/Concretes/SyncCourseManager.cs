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
            SyncCourse addSyncCourse = _mapper.Map<SyncCourse>(createSyncCourseRequest);
            SyncCourse createdSyncCourse = await _syncCourseDal.AddAsync(addSyncCourse);
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

        
        public async Task<GetByIdSyncCourseResponse> GetByIdAsync(Guid id)
        {
            var data = await _syncCourseDal.GetAsync(
                predicate: p => p.Id == id)
               ;

            var result = _mapper.Map<GetByIdSyncCourseResponse>(data);
            return result;
        }


        public async Task<IPaginate<GetListSyncCourseResponse>> GetListAsync(PageRequest pageRequest)
        {

            var data = await _syncCourseDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListSyncCourseResponse>>(data);
            return result;
        }

        public async Task<UpdatedSyncCourseResponse> UpdateAsync(UpdateSyncCourseRequest updateSyncCourseRequest)
        {
            SyncCourse updateSyncCourse = await _syncCourseDal.GetAsync(predicate: p => p.Id == updateSyncCourseRequest.Id);
            _mapper.Map(updateSyncCourseRequest, updateSyncCourse);
            SyncCourse updatedSyncCourse = await _syncCourseDal.UpdateAsync(updateSyncCourse);
            UpdatedSyncCourseResponse updatedSyncCourseResponse = _mapper.Map<UpdatedSyncCourseResponse>(updatedSyncCourse);
            return updatedSyncCourseResponse;
        }
    }

}
