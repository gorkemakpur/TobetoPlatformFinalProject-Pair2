using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SocialMediaNameManager : ISocialMediaNameService
    {
        private readonly ISocialMediaNameDal _socialMediaNameDal;
        private readonly IMapper _mapper;

        public SocialMediaNameManager(ISocialMediaNameDal socialMediaNameDal, IMapper mapper)
        {
            _socialMediaNameDal = socialMediaNameDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
