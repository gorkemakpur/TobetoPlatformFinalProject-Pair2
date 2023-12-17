using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Announcement.Response
{
    public class GetByIdAnnouncementResponse
    {
        public Guid AnnouncementTypeId { get; set; }
        //AnnouncementType tablosunun type alanı 
        public string AnnouncementTypeType { get; set; }
        public string Description { get; set; }
    }
}
