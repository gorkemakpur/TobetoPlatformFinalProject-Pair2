using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.SocialMedia.Response
{
    public class CreatedSocialMediaResponse
    {
        public Guid StudentId { get; set; }
        public Guid SocialMediaNameId { get; set; }
        public string Url { get; set; }
    }

}
