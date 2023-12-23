using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Application.Response
{
    public class GetListApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public bool IsFormAccepted { get; set; } = false;
        public bool IsDocumentAccepted { get; set; } = false;
    }
}
