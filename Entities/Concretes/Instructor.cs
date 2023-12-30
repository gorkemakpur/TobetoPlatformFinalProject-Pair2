using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor : Entity<Guid>
    {
        public Guid UserId { get; set; }

        public List<SyncCourseInstructor>? SyncCourseInstructors { get; set; }
        public User? Users { get; set; }
    }
}
