using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Announcement.Response
{
    public class DeletedAnnouncementResponse
    {
        //sildikten sonraki dönecek cevap
        public Guid AnnouncementTypeId { get; set; }
        public string AnnouncementName { get; set; }
        public string Description { get; set; }
    }
}
