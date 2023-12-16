using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AsyncCourseContent : Entity<Guid>
    {
        public Guid AsyncCourseId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public string Subtype { get; set; }
        public string Producer { get; set; }
        public string Description { get; set; }

        public AsyncCourse? AsyncCourse { get; set; }
    }
}
