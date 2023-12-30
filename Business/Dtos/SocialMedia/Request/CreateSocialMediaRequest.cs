using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.SocialMedia.Request
{
    public class CreateSocialMediaRequest
    {
        public Guid StudentId { get; set; }
        public Guid SocialMediaNameId { get; set; }
        public string Url { get; set; }
    }

}
