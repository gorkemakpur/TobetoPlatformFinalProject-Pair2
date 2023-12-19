using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

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

        // İlgili metotlar
    }
}
