using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class CertificateManager : ICertificateService
    {
        private readonly ICertificateDal _certificateDal;
        private readonly IMapper _mapper;

        public CertificateManager(ICertificateDal certificateDal, IMapper mapper)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
