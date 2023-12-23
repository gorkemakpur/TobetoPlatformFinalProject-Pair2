using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AsyncCourseManager : IAsyncCourseService
    {
        private readonly IAsyncCourseDal _asyncCourseDal;
        private readonly IMapper _mapper;

        public AsyncCourseManager(IAsyncCourseDal asyncCourseDal, IMapper mapper)
        {
            _asyncCourseDal = asyncCourseDal;
            _mapper = mapper;
        }

        public async Task<CreatedAsyncCourseResponse> AddAsync(CreateAsyncCourseRequest createAsyncCourseRequest)
        {
            //announcement türünde bir nesne oluştur mapper içerisinde createannouncementrequesti Announcement'e maple değeri değişkene ata 
            AsyncCourse addAsyncCourse = _mapper.Map<AsyncCourse>(createAsyncCourseRequest);

            //bir response değişkeni oluştur           yukarıda aldığımız veriyi ekle ve değişkene dönen değeri al 
            AsyncCourse createdAsyncCourseResponse = await _asyncCourseDal.AddAsync(addAsyncCourse);

            //son olarak request ile response'u maple
            CreatedAsyncCourseResponse createdAsyncCourse = _mapper.Map<CreatedAsyncCourseResponse>(createdAsyncCourseResponse);
            return createdAsyncCourse;
        }

        // İlgili metotlar
    }
}
