using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(3);
            RuleFor(p => p.AnnouncementTypeId).NotEmpty();
            //RuleFor(p => p.Description).MinimumLength(10).When(p => p.Description == "Merhaba");
        }
    }
}
