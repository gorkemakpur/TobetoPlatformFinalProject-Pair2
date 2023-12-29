using AutoMapper;
using Business.Dtos.Certificate.Request;
using Business.Dtos.Certificate.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CertificateMappingProfile : Profile
    {
        public CertificateMappingProfile()
        {

            //create
            CreateMap<Certificate, CreateCertificateRequest>().ReverseMap();
            CreateMap<Certificate, CreatedCertificateResponse>().ReverseMap();
            CreateMap<CreatedCertificateResponse, CreateCertificateRequest>().ReverseMap();
            //list
            CreateMap<Certificate, GetListCertificateResponse>().ReverseMap();
            CreateMap<Certificate, GetByIdCertificateResponse>().ReverseMap();
            CreateMap<IPaginate<Certificate>, Paginate<GetListCertificateResponse>>();
            //delete
            CreateMap<DeleteCertificateRequest, DeletedCertificateResponse>().ReverseMap();
            //update
            CreateMap<Certificate, UpdateCertificateRequest>().ReverseMap();
            CreateMap<UpdateCertificateRequest, UpdatedCertificateResponse>().ReverseMap();
        }
    }
}
