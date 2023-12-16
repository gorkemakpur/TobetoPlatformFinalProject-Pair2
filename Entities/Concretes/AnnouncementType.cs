using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AnnouncementType : Entity<Guid>
    {
        public string Type { get; set; }

        public List<Announcement>? Announcements { get; set; }
    }
}
