using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AsyncCourseDepartment.Response
{
    public class GetByIdAsyncCourseDepartmentResponse
    {
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid AsyncCourseId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
    }
}
