using Business.Dtos.Announcement.Request;
using Business.Dtos.Certificate.Request;
using Business.Dtos.Education.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CreateCertificateRequestValidator : AbstractValidator<CreateCertificateRequest>
    {
        public CreateCertificateRequestValidator()
        {
            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("Sertifika URL'si boş bırakılamaz.")
                //.Must(BeAValidFileType).WithMessage("Sadece image/jpeg, image/png, application/pdf yükleyebilirsiniz.")
                ;

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sertifika ismi boş bırakılamaz.");
        }

        private bool BeAValidFileType(string url)
        {
            // Basit bir dosya türü kontrolü, gerçekte daha karmaşık bir mantık gerekebilir.
            return url.EndsWith(".jpeg") || url.EndsWith(".png") || url.EndsWith(".pdf");
        }
    }
}
