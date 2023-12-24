
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Situation.Request;
using Business.Dtos.Situation.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SituationManager : ISituationService
{
    private readonly ISituationDal _situationDal;
    private readonly IMapper _mapper;

    public SituationManager(ISituationDal situationDal, IMapper mapper)
    {
        _situationDal = situationDal;
        _mapper = mapper;
    }

    public async Task<CreatedSituationResponse> AddAsync(CreateSituationRequest createSituationRequest)
    {
        Situation addSituation = _mapper.Map<Situation>(createSituationRequest);

        Situation createdSituation = await _situationDal.AddAsync(addSituation);

        CreatedSituationResponse createdSituationResponse = _mapper.Map<CreatedSituationResponse>(createdSituation);
        return createdSituationResponse;
    }

    public async Task<DeletedSituationResponse> DeleteAsync(DeleteSituationRequest deleteSituationRequest)
    {
        Situation removeSituation = await _situationDal.GetAsync(predicate: s => s.Id == deleteSituationRequest.Id);

        await _situationDal.DeleteAsync(removeSituation);

        DeletedSituationResponse deletedSituationResponse = _mapper.Map<DeletedSituationResponse>(deleteSituationRequest);
        return deletedSituationResponse;
    }

    public async Task<GetByIdSituationResponse> GetByIdAsync(Guid id)
    {
        Situation result = await _situationDal.GetAsync(predicate: s => s.Id == id);
        GetByIdSituationResponse data = _mapper.Map<GetByIdSituationResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListSituationResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _situationDal.GetListAsync(
            index: 0,//pageRequest.PageIndex,
            size: 10 //pageRequest.PageSize
            );

        var result = _mapper.Map<Paginate<GetListSituationResponse>>(data);
        return result;
    }

    public async Task<UpdatedSituationResponse> UpdateAsync(UpdateSituationRequest updateSituationRequest)
    {
        Situation updateSituation = await _situationDal.GetAsync(predicate: s => s.Id == updateSituationRequest.Id);

        _mapper.Map(updateSituationRequest, updateSituation);

        Situation updatedSituation = await _situationDal.UpdateAsync(updateSituation);

        UpdatedSituationResponse updatedSituationResponse = _mapper.Map<UpdatedSituationResponse>(updatedSituation);

        return updatedSituationResponse;
    }
}
