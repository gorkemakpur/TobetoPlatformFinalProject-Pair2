using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AsyncCourseDepartment : Entity<Guid>
    {
        public Guid DepartmentId { get; set; }
        public Guid AsyncCourseId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }

        public AsyncCourse? AsyncCourse { get; set; }
        public Department? Department { get; set; }

    }
}
