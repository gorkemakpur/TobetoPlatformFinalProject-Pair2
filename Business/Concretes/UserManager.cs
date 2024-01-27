using AutoMapper;
using Business.Abstracts;
using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }


        //14
        public async Task<GetUserResponse> Add(User user)
        {
            await _userDal.AddAsync(user);
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;
        }

        public Task<GetUserResponse> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetUserResponse> GetByMailAsync(string email)
        {
            var result = await _userDal.GetAsync(u => u.Email == email);
            GetUserResponse createdUserResponse = _mapper.Map<GetUserResponse>(result);
            return createdUserResponse;
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            var result = await _userDal.GetClaims(user);
            return result;
        }
        //--

        public async Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest)
        {
            //user türünde bir nesne oluştur mapper içerisinde createuserrequesti User'e maple değeri değişkene ata 
            User addUser = _mapper.Map<User>(createUserRequest);

            //bir response değişkeni oluştur yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            User createdUser = await _userDal.AddAsync(addUser);

            //son olarak request ile response'u maple
            CreatedUserResponse createdUserResponse = _mapper.Map<CreatedUserResponse>(createdUser);
            return createdUserResponse;
        }
     
        public async Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest)
        {
            User removeUser = await _userDal.GetAsync(predicate: a => a.Id == deleteUserRequest.Id);

            await _userDal.DeleteAsync(removeUser);

            DeletedUserResponse deletedUserResponse = _mapper.Map<DeletedUserResponse>(deleteUserRequest);

            return deletedUserResponse;
        }

      
        public async Task<GetByIdUserResponse> GetByIdAsync(Guid id)
        {
            var data = await _userDal.GetAsync(
                predicate: p => p.Id == id)
               ;

            var result = _mapper.Map<GetByIdUserResponse>(data);
            return result;
        }

       

        public async Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _userDal.GetListAsync();

            var result = _mapper.Map<Paginate<GetListUserResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
        {
            //bu kısıma bakılacak eksiklik var bütün değerleri girmeden istediğimiz değer ile update etme kısmına bakılacak
            User updateUser = await _userDal.GetAsync(predicate:p => p.Id == updateUserRequest.Id);

            _mapper.Map(updateUserRequest, updateUser);

            User updatedUser = await _userDal.UpdateAsync(updateUser);

            UpdatedUserResponse updatedUserResponse = _mapper.Map<UpdatedUserResponse>(updatedUser);

            return updatedUserResponse;
        }

    }
}
