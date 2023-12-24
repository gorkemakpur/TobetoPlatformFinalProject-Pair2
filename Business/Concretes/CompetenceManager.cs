using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Competence.Request;
using Business.Dtos.Competence.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CompetenceManager : ICompetenceService
    {
        private readonly ICompetenceDal _competenceDal;
        private readonly IMapper _mapper;

        public CompetenceManager(ICompetenceDal competenceDal, IMapper mapper)
        {
            _competenceDal = competenceDal;
            _mapper = mapper;
        }  

        public async Task<CreatedCompetenceResponse> AddAsync(CreateCompetenceRequest createCompetenceRequest)
        {
            var competence = _mapper.Map<Competence>(createCompetenceRequest);
            var result = await _competenceDal.AddAsync(competence);
            return _mapper.Map<CreatedCompetenceResponse>(result);
        }

        public async Task<DeletedCompetenceResponse> DeleteAsync(DeleteCompetenceRequest deleteCompetenceRequest)
        {
            var competence = await _competenceDal.GetAsync(x => x.Id == deleteCompetenceRequest.Id);
            var result = await _competenceDal.DeleteAsync(competence);
            return _mapper.Map<DeletedCompetenceResponse>(result);
        }

        public async Task<UpdatedCompetenceResponse> UpdateAsync(UpdateCompetenceRequest updateCompetenceRequest)
        {
            var competence = await _competenceDal.GetAsync(x => x.Id == updateCompetenceRequest.Id);
            _mapper.Map(updateCompetenceRequest, competence);
            var result = await _competenceDal.UpdateAsync(competence);
            return _mapper.Map<UpdatedCompetenceResponse>(result);
        }

        public async Task<IPaginate<GetListCompetenceResponse>> GetListAsync()
        {
            var competence = await _competenceDal.GetListAsync();
            return _mapper.Map<Paginate<GetListCompetenceResponse>>(competence);
        }
        
        public async Task<GetByIdCompetenceResponse> GetByIdAsync(Guid id)
        {
            var competence = await _competenceDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdCompetenceResponse>(competence);
        }
    }

}
