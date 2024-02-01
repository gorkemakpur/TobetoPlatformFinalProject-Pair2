using Business.Dtos.Announcement.Request;
using Business.Dtos.Auth.Request;
using Business.Dtos.Experience.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{

    public class UpdateExperienceRequestValidator : AbstractValidator<UpdateExperienceRequest>
    {
        public UpdateExperienceRequestValidator()
        {
            RuleFor(x => x.JobDescription).Length(300);

        }
    }


}
