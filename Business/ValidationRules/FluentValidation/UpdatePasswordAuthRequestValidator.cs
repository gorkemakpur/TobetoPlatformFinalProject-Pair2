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

    public class UpdatePasswordAuthRequestValidator : AbstractValidator<UpdatePasswordAuthRequest>
    {
        public UpdatePasswordAuthRequestValidator()
        {
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre alanı boş bırakılamaz.")
                .MinimumLength(8)
                .WithMessage("Şifre en az 8 karakter uzunluğunda olmalıdır.");

            RuleFor(x => x.PasswordRepeat)
                .NotEmpty()
                .WithMessage("Şifre tekrar alanı boş bırakılamaz.")
                .Equal(x => x.Password)
                .WithMessage("Şifreler uyuşmuyor.");

            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage("Şifre alanı boş bırakılamaz.");
        }
    }
}
