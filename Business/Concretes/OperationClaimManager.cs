using AutoMapper;
using Business.Abstracts;
using Business.Dtos.OperationClaim.Request;
using Business.Dtos.OperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class OperationClaimManager : IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;
        private readonly IMapper _mapper;

        public OperationClaimManager(IOperationClaimDal operationClaimDal, IMapper mapper)
        {
            _operationClaimDal = operationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest)
        {
            var operationClaim = _mapper.Map<OperationClaim>(createOperationClaimRequest);
            var result = await _operationClaimDal.AddAsync(operationClaim);
            return _mapper.Map<CreatedOperationClaimResponse>(result);
        }

        public async Task<DeletedOperationClaimResponse> DeleteAsync(DeleteOperationClaimRequest deleteOperationClaimRequest)
        {
            var operationClaim = await _operationClaimDal.GetAsync(x => x.Id == deleteOperationClaimRequest.Id);
            var result = await _operationClaimDal.DeleteAsync(operationClaim);
            return _mapper.Map<DeletedOperationClaimResponse>(result);
        }

        public async Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            var operationClaim = await _operationClaimDal.GetAsync(x => x.Id == updateOperationClaimRequest.Id);
            _mapper.Map(updateOperationClaimRequest, operationClaim);
            var result = await _operationClaimDal.UpdateAsync(operationClaim);
            return _mapper.Map<UpdatedOperationClaimResponse>(result);
        }

        public async Task<IPaginate<GetListOperationClaimResponse>> GetListAsync()
        {
            var operationClaims = await _operationClaimDal.GetListAsync();
            return _mapper.Map<Paginate<GetListOperationClaimResponse>>(operationClaims);
        }

        public async Task<GetByIdOperationClaimResponse> GetByIdAsync(int id)
        {
            var operationClaim = await _operationClaimDal.GetAsync(x => x.Id == id);
            return _mapper.Map<GetByIdOperationClaimResponse>(operationClaim);
        }
    }

}
