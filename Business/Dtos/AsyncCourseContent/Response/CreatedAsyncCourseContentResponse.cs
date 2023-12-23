using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AsyncCourseContent.Response
{
    public class CreatedAsyncCourseContentResponse
    {
        public Guid Id { get; set; }
        public Guid AsyncCourseId { get; set; }
        public string AsyncCourseName { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public string Subtype { get; set; }
        public string Producer { get; set; }
        public string Description { get; set; }
    }
}
