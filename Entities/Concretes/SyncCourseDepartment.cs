using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SyncCourseDepartment : Entity<Guid>
    {
        public Guid DepartmentId { get; set; }
        public Guid SyncCourseId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }

        public Department? Department { get; set; }
        public SyncCourse? SyncCourse { get; set; }
    }
}
