using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Certificate.Request
{
    public class UpdateCertificateRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
    }
}
