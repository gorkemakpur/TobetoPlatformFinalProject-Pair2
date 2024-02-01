using Business.Dtos.Announcement.Request;
using Business.Dtos.Auth.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   
    public class RegisterAuthRequestValidator : AbstractValidator<RegisterAuthRequest>
    {
        public RegisterAuthRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("E-posta alanı boş bırakılamaz.")
                .EmailAddress()
                .WithMessage("Geçersiz e-posta adresi.");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre alanı boş bırakılamaz.")
                .MinimumLength(8)
                .WithMessage("Şifre en az 8 karakter uzunluğunda olmalıdır.");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("İsim alanı boş bırakılamaz.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Soyisim alanı boş bırakılamaz.");
        }
    }


}
