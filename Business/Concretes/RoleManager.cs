using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        private readonly IMapper _mapper;

        public RoleManager(IRoleDal roleDal, IMapper mapper)
        {
            _roleDal = roleDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }
}
