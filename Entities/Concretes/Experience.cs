using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Experience : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public string JobDescription { get; set; }
        public string City { get; set; }
        public bool IsContinue { get; set; }

        public Student? Student { get; set; }
    }
}
