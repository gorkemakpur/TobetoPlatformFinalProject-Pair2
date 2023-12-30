using AutoMapper;
using Business.Abstracts;
using Business.Dtos.District.Request;
using Business.Dtos.District.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;
        private readonly IMapper _mapper;

        public DistrictManager(IDistrictDal districtDal, IMapper mapper)
        {
            _districtDal = districtDal;
            _mapper = mapper;
        }

        public async Task<CreatedDistrictResponse> AddAsync(CreateDistrictRequest createDistrictRequest)
        {
            var district = _mapper.Map<District>(createDistrictRequest);
            var result = await _districtDal.AddAsync(district);
            return _mapper.Map<CreatedDistrictResponse>(result);
        }

        public async Task<DeletedDistrictResponse> DeleteAsync(DeleteDistrictRequest deleteDistrictRequest)
        {
            var district = await _districtDal.GetAsync(x => x.Id == deleteDistrictRequest.Id);
            var result = await _districtDal.DeleteAsync(district);
            return _mapper.Map<DeletedDistrictResponse>(result);
        }

        public async Task<UpdatedDistrictResponse> UpdateAsync(UpdateDistrictRequest updateDistrictRequest)
        {
            var district = await _districtDal.GetAsync(x => x.Id == updateDistrictRequest.Id);
            _mapper.Map(updateDistrictRequest, district);
            var result = await _districtDal.UpdateAsync(district);
            return _mapper.Map<UpdatedDistrictResponse>(result);
        }

        public async Task<IPaginate<GetListDistrictResponse>> GetListAsync()
        {
            var districts = await _districtDal.GetListAsync();
            return _mapper.Map<Paginate<GetListDistrictResponse>>(districts);
        }
        
        public async Task<GetByIdDistrictResponse> GetByIdAsync(Guid id)
        {
            var district = await _districtDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdDistrictResponse>(district);
        }
    }
}
