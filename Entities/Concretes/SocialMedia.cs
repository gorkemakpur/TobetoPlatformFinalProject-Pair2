using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SocialMedia : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid SocialMediaNameId { get; set; }
        public string Url { get; set; }

        public Student Students { get; set; }
        public SocialMediaName SocialMediaName { get; set; }
    }
}
