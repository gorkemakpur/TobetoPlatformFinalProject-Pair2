﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AsyncCourse.Request
{
    public class CreateAsyncCourseRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

    }
}
