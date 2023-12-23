using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AnnouncementType.Request
{
    public class UpdateAnnouncementTypeRequest
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
    }
}
