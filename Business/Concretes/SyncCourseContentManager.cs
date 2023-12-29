using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SyncCourseContent.Request;
using Business.Dtos.SyncCourseContent.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

public class SyncCourseContentManager : ISyncCourseContentService
{
    private readonly ISyncCourseContentDal _syncCourseContentDal;
    private readonly IMapper _mapper;

    public SyncCourseContentManager(ISyncCourseContentDal syncCourseContentDal, IMapper mapper)
    {
        _syncCourseContentDal = syncCourseContentDal;
        _mapper = mapper;
    }

    public async Task<CreatedSyncCourseContentResponse> AddAsync(CreateSyncCourseContentRequest createSyncCourseContentRequest)
    {
        SyncCourseContent addSyncCourseContent = _mapper.Map<SyncCourseContent>(createSyncCourseContentRequest);
        SyncCourseContent createdSyncCourseContent = await _syncCourseContentDal.AddAsync(addSyncCourseContent);
        CreatedSyncCourseContentResponse createdSyncCourseContentResponse = _mapper.Map<CreatedSyncCourseContentResponse>(createdSyncCourseContent);
        return createdSyncCourseContentResponse;
    }

    public async Task<DeletedSyncCourseContentResponse> DeleteAsync(DeleteSyncCourseContentRequest deleteSyncCourseContentRequest)
    {
        SyncCourseContent removeSyncCourseContent = await _syncCourseContentDal.GetAsync(predicate: c => c.Id == deleteSyncCourseContentRequest.Id);
        await _syncCourseContentDal.DeleteAsync(removeSyncCourseContent);

        DeletedSyncCourseContentResponse deletedSyncCourseContentResponse = _mapper.Map<DeletedSyncCourseContentResponse>(deleteSyncCourseContentRequest);
        return deletedSyncCourseContentResponse;
    }

    public async Task<GetByIdSyncCourseContentResponse> GetByIdAsync(Guid id)
    {

        SyncCourseContent result = await _syncCourseContentDal.GetAsync(predicate:c => c.Id == id);
        GetByIdSyncCourseContentResponse data = _mapper.Map<GetByIdSyncCourseContentResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListSyncCourseContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _syncCourseContentDal.GetListAsync(
            index: 0, // pageRequest.PageIndex,
            size: 10   // pageRequest.PageSize
        );

        var result = _mapper.Map<Paginate<GetListSyncCourseContentResponse>>(data);
        return result;
    }

    public async Task<UpdatedSyncCourseContentResponse> UpdateAsync(UpdateSyncCourseContentRequest updateSyncCourseContentRequest)
    {
        SyncCourseContent updateSyncCourseContent = await _syncCourseContentDal.GetAsync(predicate:c => c.Id == updateSyncCourseContentRequest.Id);
        _mapper.Map(updateSyncCourseContentRequest, updateSyncCourseContent);

        SyncCourseContent updatedSyncCourseContent = await _syncCourseContentDal.UpdateAsync(updateSyncCourseContent);
        UpdatedSyncCourseContentResponse updatedSyncCourseContentResponse = _mapper.Map<UpdatedSyncCourseContentResponse>(updatedSyncCourseContent);

        return updatedSyncCourseContentResponse;
    }
}
