using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.SyncCourse.Response
{
    public class CreatedSyncCourseResponse
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Subtype { get; set; }
    }
}
