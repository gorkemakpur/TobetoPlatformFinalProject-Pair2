using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SyncCourse : Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Subtype { get; set; }

        public Category? Category { get; set; }
        public List<SyncCourse>? SyncCourses { get; set; }
        public List<SyncCourseContent>? SyncCourseContents { get; set; }

    }
}
