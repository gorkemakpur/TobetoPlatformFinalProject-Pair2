using AutoMapper;
using Business.Abstracts;
using Business.Dtos.UserOperationClaim.Request;
using Business.Dtos.UserOperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;
        private readonly IMapper _mapper;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal, IMapper mapper)
        {
            _userOperationClaimDal = userOperationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            var userOperationClaim = _mapper.Map<UserOperationClaim>(createUserOperationClaimRequest);
            var result = await _userOperationClaimDal.AddAsync(userOperationClaim);
            return _mapper.Map<CreatedUserOperationClaimResponse>(result);
        }

        public async Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest)
        {
            var userOperationClaim = await _userOperationClaimDal.GetAsync(x => x.Id == deleteUserOperationClaimRequest.Id);
            var result = await _userOperationClaimDal.DeleteAsync(userOperationClaim);
            return _mapper.Map<DeletedUserOperationClaimResponse>(result);
        }

        public async Task<UpdatedUserOperationClaimResponse> UpdateAsync(UpdateUserOperationClaimRequest updateUserOperationClaimRequest)
        {
            var userOperationClaim = await _userOperationClaimDal.GetAsync(x => x.Id == updateUserOperationClaimRequest.Id);
            _mapper.Map(updateUserOperationClaimRequest, userOperationClaim);
            var result = await _userOperationClaimDal.UpdateAsync(userOperationClaim);
            return _mapper.Map<UpdatedUserOperationClaimResponse>(result);
        }

        public async Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync()
        {
            var userOperationClaims = await _userOperationClaimDal.GetListAsync();
            return _mapper.Map<Paginate<GetListUserOperationClaimResponse>>(userOperationClaims);
        }

        public async Task<GetByIdUserOperationClaimResponse> GetByIdAsync(int id)
        {
            var userOperationClaim = await _userOperationClaimDal.GetAsync(x => x.Id == id);
            return _mapper.Map<GetByIdUserOperationClaimResponse>(userOperationClaim);
        }
    }

}
