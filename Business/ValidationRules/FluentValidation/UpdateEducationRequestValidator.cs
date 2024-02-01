using Business.Dtos.Announcement.Request;
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
    public class UpdateEducationRequestValidator : AbstractValidator<UpdateEducationRequest>
    {
        public UpdateEducationRequestValidator()
        {
            RuleFor(request => request.University)
                .NotEmpty().WithMessage("Üniversite bilgisi boş bırakılamaz.")
                .MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz.")
                .MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");

            RuleFor(request => request.Department)
                .NotEmpty().WithMessage("Bölüm bilgisi boş bırakılamaz.")
                .MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz.")
                .MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");

        }
    }
}
