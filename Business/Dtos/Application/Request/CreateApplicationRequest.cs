using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Application.Request
{
    public class CreateApplicationRequest
    {
        public Guid StudentId { get; set; }
        public bool IsFormAccepted { get; set; }
        public bool IsDocumentAccepted { get; set; }
    }
}
