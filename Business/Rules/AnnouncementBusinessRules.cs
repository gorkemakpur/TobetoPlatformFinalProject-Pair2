using Business.Abstracts;
using Business.Dtos.Announcement.Response;
using Business.Messagess;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
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
        public async Task CheckAnnouncementLimit()
        {
            var result = await _announcementDal.GetListAsync();
            if (result.Count == 10)
            {
                throw new BusinessException(Messages.LimitUnBound);
            }
        }


    }
}
