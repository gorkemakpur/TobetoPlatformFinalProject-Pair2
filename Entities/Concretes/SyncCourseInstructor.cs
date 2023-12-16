using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SyncCourseInstructor : Entity<Guid>
    {
        public Guid SyncCourseContentId { get; set; }
        public Guid InstructorId { get; set; }

        public SyncCourseContent? SyncCourseContent { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
