using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Announcement.Request
{
    public class CreateAnnouncementRequest
    {
        public Guid AnnouncementTypeId { get; set; }
        public string Description { get; set; }
    }
}
