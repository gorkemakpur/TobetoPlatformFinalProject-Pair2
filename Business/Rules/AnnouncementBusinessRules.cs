using Business.Abstracts;
using Business.Dtos.Announcement.Response;
using Core.Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AnnouncementBusinessRules : BaseBusinessRules
    {
        IAnnouncementDal _announcementDal;
        //başka bir dalı implemente edemezsin ama service'i edebilirsin
        IAnnouncementTypeService _announcementTypeService;

        public AnnouncementBusinessRules(IAnnouncementDal announcementDal, IAnnouncementTypeService announcementTypeService)
        {
            _announcementDal = announcementDal;
            _announcementTypeService = announcementTypeService;
        }
        //rules örnek
        public async Task CheckAnnouncementLimit(Guid id)
        {
            var result = await _announcementDal.GetListAsync(
                predicate: p=>p.AnnouncementTypeId==id,
                size:10
                );
            if (result.Count >= 5)
            {
                throw new Exception("Limit aşıldı");
            }
        }


    }
}
