using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
    }
}
