using AutoMapper;
using Business.Abstracts;
using Business.Dtos.City.Request;
using Business.Dtos.City.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

public class CityManager : ICityService
{
    private readonly ICityDal _cityDal;
    private readonly IMapper _mapper;

    public CityManager(ICityDal cityDal, IMapper mapper)
    {
        _cityDal = cityDal;
        _mapper = mapper;
    }

    public async Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest)
    {
        City addCity = _mapper.Map<City>(createCityRequest);
        City createdCity = await _cityDal.AddAsync(addCity);
        CreatedCityResponse createdCityResponse = _mapper.Map<CreatedCityResponse>(createdCity);
        return createdCityResponse;
    }

    public async Task<DeletedCityResponse> DeleteAsync(DeleteCityRequest deleteCityRequest)
    {
        City removeCity = await _cityDal.GetAsync(predicate: c => c.Id == deleteCityRequest.Id);
        await _cityDal.DeleteAsync(removeCity);

        DeletedCityResponse deletedCityResponse = _mapper.Map<DeletedCityResponse>(deleteCityRequest);
        return deletedCityResponse;
    }

    public async Task<GetByIdCityResponse> GetByIdAsync(Guid id)
    {
        City result = await _cityDal.GetAsync(predicate:c => c.Id == id);
        GetByIdCityResponse data = _mapper.Map<GetByIdCityResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListCityResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _cityDal.GetListAsync(
            index: 0, // pageRequest.PageIndex,
            size: 10   // pageRequest.PageSize
        );

        var result = _mapper.Map<Paginate<GetListCityResponse>>(data);
        return result;
    }

    public async Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest)
    {
        City updateCity = await _cityDal.GetAsync(predicate:c => c.Id == updateCityRequest.Id);
        _mapper.Map(updateCityRequest, updateCity);

        City updatedCity = await _cityDal.UpdateAsync(updateCity);
        UpdatedCityResponse updatedCityResponse = _mapper.Map<UpdatedCityResponse>(updatedCity);

        return updatedCityResponse;
    }
}
