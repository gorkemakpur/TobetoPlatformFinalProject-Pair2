using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class OperationClaim : Entity<Guid>
    {
        //14
        public string Name { get; set; }
        public ICollection<UserOperationClaim> Users { get; set; }
    }
}
