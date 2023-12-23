using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.Application.Request;
using Business.Dtos.Application.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationDal _applicationDal;
        private readonly IMapper _mapper;

        public ApplicationManager(IApplicationDal applicationDal, IMapper mapper)
        {
            _applicationDal = applicationDal;
            _mapper = mapper;
        }

        public async Task<CreatedApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest)
        {
            Application addApplication = _mapper.Map<Application>(createApplicationRequest);
            Application createdApplicationResponse = await _applicationDal.AddAsync(addApplication);
            CreatedApplicationResponse createdApplication = _mapper.Map<CreatedApplicationResponse>(createdApplicationResponse);
            return createdApplication;
        }

        public async Task<DeletedApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            Application removeApplication = await _applicationDal.GetAsync(predicate: a => a.Id == deleteApplicationRequest.Id);
            await _applicationDal.DeleteAsync(removeApplication);
            DeletedApplicationResponse deletedApplicationResponse = _mapper.Map<DeletedApplicationResponse>(deleteApplicationRequest);
            return deletedApplicationResponse;
        }

        public async Task<GetByIdApplicationResponse> GetByIdAsync(Guid id)
        {
            var data = await _applicationDal.GetAsync(predicate: p => p.Id == id);

            var result = _mapper.Map<GetByIdApplicationResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListApplicationResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _applicationDal.GetListAsync(index: 0,//pageRequest.PageIndex,
                                                          size: 10 //pageRequest.PageSize
    );

            var result = _mapper.Map<Paginate<GetListApplicationResponse>>(data);
            return result;
        }

        public async Task<UpdatedApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            Application updateApplication = await _applicationDal.GetAsync(p => p.Id == updateApplicationRequest.Id);
            _mapper.Map(updateApplicationRequest, updateApplication);
            Application updatedApplication = await _applicationDal.UpdateAsync(updateApplication);
            UpdatedApplicationResponse updatedApplicationResponse = _mapper.Map<UpdatedApplicationResponse>(updatedApplication);

            return updatedApplicationResponse;
        }
    }


}
