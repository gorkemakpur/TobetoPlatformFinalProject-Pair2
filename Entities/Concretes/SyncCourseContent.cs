using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SyncCourseContent : Entity<Guid>
    {
        public Guid SyncCourseId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }

        public SyncCourse? SyncCourse { get; set; }
        public List<SyncCourseInstructor>? SyncCourseInstructors { get; set; }
    }
}
