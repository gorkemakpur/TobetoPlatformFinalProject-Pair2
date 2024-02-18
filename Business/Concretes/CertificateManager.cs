﻿using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Certificate.Request;
using Business.Dtos.Certificate.Response;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class CertificateManager : ICertificateService
{
    private readonly ICertificateDal _certificateDal;
    private readonly IMapper _mapper;

    public CertificateManager(ICertificateDal certificateDal, IMapper mapper)
    {
        _certificateDal = certificateDal;
        _mapper = mapper;
    }


    [ValidationAspect(typeof(CreateCertificateRequestValidator))]
    public async Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest)
    {
        Certificate addCertificate = _mapper.Map<Certificate>(createCertificateRequest);
        Certificate createdCertificate = await _certificateDal.AddAsync(addCertificate);
        CreatedCertificateResponse createdCertificateResponse = _mapper.Map<CreatedCertificateResponse>(createdCertificate);
        return createdCertificateResponse;
    }

    public async Task<DeletedCertificateResponse> DeleteAsync(DeleteCertificateRequest deleteCertificateRequest)
    {
        Certificate removeCertificate = await _certificateDal.GetAsync(predicate: c => c.Id == deleteCertificateRequest.Id);
        await _certificateDal.DeleteAsync(removeCertificate);

        DeletedCertificateResponse deletedCertificateResponse = _mapper.Map<DeletedCertificateResponse>(deleteCertificateRequest);
        return deletedCertificateResponse;
    }

    public async Task<GetByIdCertificateResponse> GetByIdAsync(Guid id)
    {
        Certificate result = await _certificateDal.GetAsync(predicate: c => c.Id == id);
        GetByIdCertificateResponse data = _mapper.Map<GetByIdCertificateResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListCertificateResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _certificateDal.GetListAsync(
            index: 0, // pageRequest.PageIndex,
            size: 10   // pageRequest.PageSize
        );

        var result = _mapper.Map<Paginate<GetListCertificateResponse>>(data);
        return result;
    }

    public async Task<IPaginate<GetListCertificateResponse>> GetListAsPageByUserId(PageRequest pageRequest, Guid userId)
    {
        var data = await _certificateDal.GetListAsync(
            x => x.Student.UserId == userId,
                    include: query => query.Include(x => x.Student),
            index: 0, // pageRequest.PageIndex,
            size: 100   // pageRequest.PageSize
        );

        var result = _mapper.Map<Paginate<GetListCertificateResponse>>(data);
        return result;
    }

    public async Task<UpdatedCertificateResponse> UpdateAsync(UpdateCertificateRequest updateCertificateRequest)
    {
        Certificate updateCertificate = await _certificateDal.GetAsync(predicate: c => c.Id == updateCertificateRequest.Id);
        _mapper.Map(updateCertificateRequest, updateCertificate);

        Certificate updatedCertificate = await _certificateDal.UpdateAsync(updateCertificate);
        UpdatedCertificateResponse updatedCertificateResponse = _mapper.Map<UpdatedCertificateResponse>(updatedCertificate);

        return updatedCertificateResponse;
    }

}
