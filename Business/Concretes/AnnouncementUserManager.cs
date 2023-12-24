using AutoMapper;
using Business.Abstracts;
using Business.Dtos.AnnouncementUser.Request;
using Business.Dtos.AnnouncementUser.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AnnouncementUserManager : IAnnouncementUserService
    {
        private readonly IAnnouncementUserDal _announcementUserDal;
        private readonly IMapper _mapper;

        public AnnouncementUserManager(IAnnouncementUserDal announcementUserDal, IMapper mapper)
        {
            _announcementUserDal = announcementUserDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementUserResponse> AddAsync(CreateAnnouncementUserRequest createAnnouncementUserRequest)
        {
            var announcementUser = _mapper.Map<AnnouncementUser>(createAnnouncementUserRequest);
            var result = await _announcementUserDal.AddAsync(announcementUser);
            return _mapper.Map<CreatedAnnouncementUserResponse>(result);
        }

        public async Task<DeletedAnnouncementUserResponse> DeleteAsync(DeleteAnnouncementUserRequest deleteAnnouncementUserRequest)
        {
            var announcementUser = await _announcementUserDal.GetAsync(x => x.Id == deleteAnnouncementUserRequest.Id);
            var result = await _announcementUserDal.DeleteAsync(announcementUser);
            return _mapper.Map<DeletedAnnouncementUserResponse>(result);
        }

        public async Task<UpdatedAnnouncementUserResponse> UpdateAsync(UpdateAnnouncementUserRequest updateAnnouncementUserRequest)
        {
            var announcementUser = await _announcementUserDal.GetAsync(x => x.Id == updateAnnouncementUserRequest.Id);
            _mapper.Map(updateAnnouncementUserRequest, announcementUser);
            var result = await _announcementUserDal.UpdateAsync(announcementUser);
            return _mapper.Map<UpdatedAnnouncementUserResponse>(result);
        }

        public async Task<IPaginate<GetListAnnouncementUserResponse>> GetListAsync()
        {
            var announcementUsers = await _announcementUserDal.GetListAsync();
            return _mapper.Map<Paginate<GetListAnnouncementUserResponse>>(announcementUsers);
        }
        
        public async Task<GetByIdAnnouncementUserResponse> GetByIdAsync(Guid id)
        {
            var announcementUser = await _announcementUserDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdAnnouncementUserResponse>(announcementUser);
        }
    }
}
