using Business.Dtos.Announcement.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    /// <summary>
    /// announcement verince çalışmıyor çünkü kod create announcement olarak dto sınıfını çekiyor !!!
    /// mantıken kalan aspectlerde bu şekilde yazılması gerekecektir 
    /// bu şimdilik örnek olarak kalsın derste soracağım
    /// </summary>
    public class CreateAnnouncementValidator : AbstractValidator<CreateAnnouncementRequest>
    {
        public CreateAnnouncementValidator() 
        {
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(3);
            //RuleFor(p => p.AnnouncementTypeId).NotEmpty();
            //RuleFor(p => p.Description).MinimumLength(10).When(p => p.Description == "Merhaba");
        }
    }
}
