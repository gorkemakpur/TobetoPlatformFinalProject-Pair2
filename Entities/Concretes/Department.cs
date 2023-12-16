using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Department : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Student>? Students { get; set; }
        public List<AsyncCourseDepartment>? AsyncCourseDepartments { get; set; }
        public List<SyncCourseDepartment>? SyncCourseDepartments { get; set; }
    }
}
