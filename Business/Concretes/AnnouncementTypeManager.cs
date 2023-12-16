using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class AnnouncementTypeManager : IAnnouncementTypeService
    {
        private readonly IAnnouncementTypeDal _announcementTypeDal;
        private readonly IMapper _mapper;

        public AnnouncementTypeManager(IAnnouncementTypeDal announcementTypeDal, IMapper mapper)
        {
            _announcementTypeDal = announcementTypeDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }


}
