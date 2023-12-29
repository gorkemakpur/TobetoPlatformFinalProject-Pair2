using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Category.Request
{
    public class UpdateCategoryRequest
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public List<Guid>? SyncCourses { get; set; }
        public List<Guid>? AsyncCourses { get; set; }
    }
}
