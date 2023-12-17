using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Announcement.Request
{
    public class DeleteAnnouncementRequest
    {
        //id ye göre veriyi getirip silecek
        public Guid Id { get; set; }
    }
}
