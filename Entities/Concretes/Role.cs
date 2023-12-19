using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Role : Entity<Guid>
    {
        public string Type { get; set; }
        public List<User>? Users { get; set; }
    }
}
