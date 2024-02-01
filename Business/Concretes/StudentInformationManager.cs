using AutoMapper;
using Business.Abstracts;
using Business.BusinessAspects.Autofac;
using Business.Dtos.StudentInformation.Request;
using Business.Dtos.StudentInformation.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class StudentInformationManager : IStudentInformationService
    {
        private readonly IStudentInformationDal _studentInformationDal;
        private readonly IMapper _mapper;

        public StudentInformationManager(IStudentInformationDal studentInformationDal, IMapper mapper)
        {
            _studentInformationDal = studentInformationDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CreateStudentInformationRequestValidator))]
        public async Task<CreatedStudentInformationResponse> AddAsync(CreateStudentInformationRequest createStudentInformationRequest)
        {

            StudentInformation addStudentInformation = _mapper.Map<StudentInformation>(createStudentInformationRequest);
            StudentInformation createdStudentInformationResponse = await _studentInformationDal.AddAsync(addStudentInformation);
            CreatedStudentInformationResponse createdStudentInformation = _mapper.Map<CreatedStudentInformationResponse>(createdStudentInformationResponse);
            return createdStudentInformation;
        }

        public async Task<DeletedStudentInformationResponse> DeleteAsync(DeleteStudentInformationRequest deleteStudentInformationRequest)
        {
            StudentInformation removeStudentInformation = await _studentInformationDal.GetAsync(predicate: a => a.Id == deleteStudentInformationRequest.Id);
            await _studentInformationDal.DeleteAsync(removeStudentInformation);
            DeletedStudentInformationResponse deletedStudentInformationResponse = _mapper.Map<DeletedStudentInformationResponse>(deleteStudentInformationRequest);
            return deletedStudentInformationResponse;
        }


        public async Task<GetByIdStudentInformationResponse> GetByIdAsync(Guid id)
        {
            var data = await _studentInformationDal.GetAsync(
                predicate: p => p.Id == id
                );

            var result = _mapper.Map<GetByIdStudentInformationResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListStudentInformationResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _studentInformationDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListStudentInformationResponse>>(data);
            return result;
        }

        [ValidationAspect(typeof(UpdateStudentInformationRequestValidator))]
        public async Task<UpdatedStudentInformationResponse> UpdateAsync(UpdateStudentInformationRequest updateStudentInformationRequest)
        {
            StudentInformation updateStudentInformation = await _studentInformationDal.GetAsync(p => p.Id == updateStudentInformationRequest.Id);
            _mapper.Map(updateStudentInformationRequest, updateStudentInformation);
            StudentInformation updatedStudentInformation = await _studentInformationDal.UpdateAsync(updateStudentInformation);
            UpdatedStudentInformationResponse updatedStudentInformationResponse = _mapper.Map<UpdatedStudentInformationResponse>(updatedStudentInformation);

            return updatedStudentInformationResponse;
        }

        public async Task<StudentInformation> TransactionalOperation(StudentInformation studentInformation)
        {
            await _studentInformationDal.UpdateAsync(studentInformation);
            await _studentInformationDal.AddAsync(studentInformation);

            return studentInformation;
        }
    }
}
