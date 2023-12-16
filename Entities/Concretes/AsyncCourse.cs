using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AsyncCourse : Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        public Category? Category { get; set; }
        public List<AsyncCourseDepartment>? AsyncCourseDepartments { get; set; }
        public List<AsyncCourseContent>? AsyncCourseContents { get; set; }
    }
}
