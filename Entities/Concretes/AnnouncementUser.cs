using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AnnouncementUser : Entity<Guid>
    {
        public Guid AnnouncementId { get; set; }
        public Guid UserId { get; set; }
        public bool IsRead { get; set; }

        public Announcement? Announcement { get; set; }
        public User? User { get; set; }
    }
}
