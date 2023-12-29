using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.City.Request
{
    public class UpdateCityRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
