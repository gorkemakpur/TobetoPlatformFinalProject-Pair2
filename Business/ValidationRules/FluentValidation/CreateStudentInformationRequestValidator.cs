using Business.Dtos.Auth.Request;
using Business.Dtos.StudentInformation.Request;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreateStudentInformationRequestValidator : AbstractValidator<CreateStudentInformationRequest>
    {
        public CreateStudentInformationRequestValidator()
        {
            RuleFor(request => request.DistrictId)
                .NotEmpty().WithMessage("Doldurulması Zorunlu Alan");

            RuleFor(request => request.BirthDate)
                .NotEmpty().WithMessage("Doldurulması Zorunlu Alan");

            RuleFor(request => request.NationalityId)
                .NotEmpty().WithMessage("TC kimlik no doldurulması zorunlu alandır. Aboneliklerde fatura için doldurulması zorunlu alan");

            RuleFor(request => request.PhoneNumber)
                .NotEmpty().WithMessage("Doldurulması Zorunlu Alan");

            RuleFor(request => request.Country)
                .NotEmpty().WithMessage("Doldurulması Zorunlu Alan");
        }
    }
}