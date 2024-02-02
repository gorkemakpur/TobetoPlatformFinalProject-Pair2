using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Education.Request;
using Business.Dtos.Education.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using Core.Utilities.Business;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;
        private readonly IMapper _mapper;
        private readonly EducationBusinessRules _educationBusinessRules;

        public EducationManager(IEducationDal educationDal, IMapper mapper, EducationBusinessRules educationBusinessRules)
        {
            _educationDal = educationDal;
            _mapper = mapper;
            _educationBusinessRules = educationBusinessRules;
        }


        [ValidationAspect(typeof(CreateEducationRequestValidator))]
        public async Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest)
        {
            var education = _mapper.Map<Education>(createEducationRequest);
            var result = await _educationDal.AddAsync(education);
            return _mapper.Map<CreatedEducationResponse>(result);
        }

        public async Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deleteEducationRequest)
        {
            var education = await _educationDal.GetAsync(x => x.Id == deleteEducationRequest.Id);
            await _educationBusinessRules.EnsureEducationIsNotNull(education);
            var result = await _educationDal.DeleteAsync(education);
            return _mapper.Map<DeletedEducationResponse>(result);
        }

        public async Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest)
        {
            var education = await _educationDal.GetAsync(x => x.Id == updateEducationRequest.Id);
            _mapper.Map(updateEducationRequest, education);
            await _educationBusinessRules.EnsureEducationIsNotNull(education);
            var result = await _educationDal.UpdateAsync(education);
            return _mapper.Map<UpdatedEducationResponse>(result);
        }

        public async Task<IPaginate<GetListEducationResponse>> GetListAsync()
        {
            var educations = await _educationDal.GetListAsync();
            return _mapper.Map<Paginate<GetListEducationResponse>>(educations);
        }

        public async Task<GetByIdEducationResponse> GetByIdAsync(Guid id)
        {
            var education = await _educationDal.GetAsync(x => x.Id == id);
            await _educationBusinessRules.EnsureEducationIsNotNull(education);
            return _mapper.Map<GetByIdEducationResponse>(education);
        }
    }

}
