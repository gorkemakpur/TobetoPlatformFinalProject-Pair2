using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SyncCourseInstructor.Request;
using Business.Dtos.SyncCourseInstructor.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    // Diğer Manager (Service) Sınıfları...
    public class SyncCourseInstructorManager : ISyncCourseInstructorService
    {
        private readonly ISyncCourseInstructorDal _syncCourseInstructorDal;
        private readonly IMapper _mapper;

        public SyncCourseInstructorManager(ISyncCourseInstructorDal syncCourseInstructorDal, IMapper mapper)
        {
            _syncCourseInstructorDal = syncCourseInstructorDal;
            _mapper = mapper;
        }

        public async Task<CreatedSyncCourseInstructorResponse> AddAsync(CreateSyncCourseInstructorRequest createSyncCourseInstructorRequest)
        {
            var syncCourseInstructor = _mapper.Map<SyncCourseInstructor>(createSyncCourseInstructorRequest);
            var result = await _syncCourseInstructorDal.AddAsync(syncCourseInstructor);
            return _mapper.Map<CreatedSyncCourseInstructorResponse>(result);
        }

        public async Task<DeletedSyncCourseInstructorResponse> DeleteAsync(DeleteSyncCourseInstructorRequest deleteSyncCourseInstructorRequest)
        {
            var syncCourseInstructor = await _syncCourseInstructorDal.GetAsync(x => x.Id == deleteSyncCourseInstructorRequest.Id);
            var result = await _syncCourseInstructorDal.DeleteAsync(syncCourseInstructor);
            return _mapper.Map<DeletedSyncCourseInstructorResponse>(result);
        }

        public async Task<UpdatedSyncCourseInstructorResponse> UpdateAsync(UpdateSyncCourseInstructorRequest updateSyncCourseInstructorRequest)
        {
            var syncCourseInstructor = await _syncCourseInstructorDal.GetAsync(x => x.Id == updateSyncCourseInstructorRequest.Id);
            _mapper.Map(updateSyncCourseInstructorRequest, syncCourseInstructor);
            var result = await _syncCourseInstructorDal.UpdateAsync(syncCourseInstructor);
            return _mapper.Map<UpdatedSyncCourseInstructorResponse>(result);
        }

        public async Task<IPaginate<GetListSyncCourseInstructorResponse>> GetListAsync()
        {
            var syncCourseInstructors = await _syncCourseInstructorDal.GetListAsync();
            return _mapper.Map<Paginate<GetListSyncCourseInstructorResponse>>(syncCourseInstructors);
        }
        
        public async Task<GetByIdSyncCourseInstructorResponse> GetByIdAsync(Guid id)
        {
            var syncCourseInstructor = await _syncCourseInstructorDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdSyncCourseInstructorResponse>(syncCourseInstructor);
        }
    }

}
