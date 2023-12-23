using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Application.Response
{
    public class DeletedApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
    }
}
