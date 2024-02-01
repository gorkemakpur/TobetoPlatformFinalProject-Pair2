using AutoMapper;
using Business.Abstracts;
<<<<<<< Updated upstream
=======
using Business.Dtos.Experience.Request;
using Business.Dtos.Experience.Response;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
>>>>>>> Stashed changes
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        private readonly IMapper _mapper;

        public ExperienceManager(IExperienceDal experienceDal, IMapper mapper)
        {
            _experienceDal = experienceDal;
            _mapper = mapper;
        }

<<<<<<< Updated upstream
        // İlgili metotlar
=======
        [ValidationAspect(typeof(CreateExperienceRequestValidator))]
        public async Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest)
        {
            var experience = _mapper.Map<Experience>(createExperienceRequest);
            var result = await _experienceDal.AddAsync(experience);
            return _mapper.Map<CreatedExperienceResponse>(result);
        }

        public async Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceRequest)
        {
            var experience = await _experienceDal.GetAsync(x => x.Id == deleteExperienceRequest.Id);
            var result = await _experienceDal.DeleteAsync(experience);
            return _mapper.Map<DeletedExperienceResponse>(result);
        }

        public async Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest)
        {
            var experience = await _experienceDal.GetAsync(x => x.Id == updateExperienceRequest.Id);
            _mapper.Map(updateExperienceRequest, experience);
            var result = await _experienceDal.UpdateAsync(experience);
            return _mapper.Map<UpdatedExperienceResponse>(result);
        }

        public async Task<IPaginate<GetListExperienceResponse>> GetListAsync()
        {
            var experiences = await _experienceDal.GetListAsync();
            return _mapper.Map<Paginate<GetListExperienceResponse>>(experiences);
        }

        public async Task<GetByIdExperienceResponse> GetByIdAsync(Guid id)
        {
            var experience = await _experienceDal.GetAsync(x => x.Id == id);
            return _mapper.Map<GetByIdExperienceResponse>(experience);
        }
>>>>>>> Stashed changes
    }

}
