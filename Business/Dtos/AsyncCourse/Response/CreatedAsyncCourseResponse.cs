﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.AsyncCourse.Response
{
    public class CreatedAsyncCourseResponse
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
