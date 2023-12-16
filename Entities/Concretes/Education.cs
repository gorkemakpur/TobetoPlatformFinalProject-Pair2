using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Education : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid SituationId { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public bool IsContinue { get; set; }

        public Student? Student { get; set; }
        public Situation? Situation { get; set; }
    }
}
