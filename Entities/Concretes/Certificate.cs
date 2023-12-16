using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Certificate : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }

        public Student? Student { get; set; }
    }
}
