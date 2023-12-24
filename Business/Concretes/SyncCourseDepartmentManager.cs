using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SyncCourseDepartment.Request;
using Business.Dtos.SyncCourseDepartment.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SyncCourseDepartmentManager : ISyncCourseDepartmentService
    {
        private readonly ISyncCourseDepartmentDal _syncCourseDepartmentDal;
        private readonly IMapper _mapper;

        public SyncCourseDepartmentManager(ISyncCourseDepartmentDal syncCourseDepartmentDal, IMapper mapper)
        {
            _syncCourseDepartmentDal = syncCourseDepartmentDal;
            _mapper = mapper;
        }

        public async Task<CreatedSyncCourseDepartmentResponse> AddAsync(CreateSyncCourseDepartmentRequest createSyncCourseDepartmentRequest)
        {
            var syncCourseDepartment = _mapper.Map<SyncCourseDepartment>(createSyncCourseDepartmentRequest);
            var result = await _syncCourseDepartmentDal.AddAsync(syncCourseDepartment);
            return _mapper.Map<CreatedSyncCourseDepartmentResponse>(result);
        }

        public async Task<DeletedSyncCourseDepartmentResponse> DeleteAsync(DeleteSyncCourseDepartmentRequest deleteSyncCourseDepartmentRequest)
        {
            var syncCourseDepartment = await _syncCourseDepartmentDal.GetAsync(x => x.Id == deleteSyncCourseDepartmentRequest.Id);
            var result = await _syncCourseDepartmentDal.DeleteAsync(syncCourseDepartment);
            return _mapper.Map<DeletedSyncCourseDepartmentResponse>(result);
        }

        public async Task<UpdatedSyncCourseDepartmentResponse> UpdateAsync(UpdateSyncCourseDepartmentRequest updateSyncCourseDepartmentRequest)
        {
            var syncCourseDepartment = await _syncCourseDepartmentDal.GetAsync(x => x.Id == updateSyncCourseDepartmentRequest.Id);
            _mapper.Map(updateSyncCourseDepartmentRequest, syncCourseDepartment);
            var result = await _syncCourseDepartmentDal.UpdateAsync(syncCourseDepartment);
            return _mapper.Map<UpdatedSyncCourseDepartmentResponse>(result);
        }

        public async Task<IPaginate<GetListSyncCourseDepartmentResponse>> GetListAsync()
        {
            var syncCourseDepartments = await _syncCourseDepartmentDal.GetListAsync();
            return _mapper.Map<Paginate<GetListSyncCourseDepartmentResponse>>(syncCourseDepartments);
        }
        
        public async Task<GetByIdSyncCourseDepartmentResponse> GetByIdAsync(Guid id)
        {
            var syncCourseDepartment = await _syncCourseDepartmentDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdSyncCourseDepartmentResponse>(syncCourseDepartment);
        }
    }
}