using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Certificate.Request
{
    public class GetListByUserIdRequest
    {
        public Guid UserId { get; set; }
    }
}
