using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

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
            AsyncCourse addAsyncCourse = _mapper.Map<AsyncCourse>(createAsyncCourseRequest);
            AsyncCourse createdAsyncCourseResponse = await _asyncCourseDal.AddAsync(addAsyncCourse);
            CreatedAsyncCourseResponse createdAsyncCourse = _mapper.Map<CreatedAsyncCourseResponse>(createdAsyncCourseResponse);
            return createdAsyncCourse;
        }

        public async Task<DeletedAsyncCourseResponse> DeleteAsync(DeleteAsyncCourseRequest deleteAsyncCourseRequest)
        {
            AsyncCourse removeAsyncCourse = await _asyncCourseDal.GetAsync(predicate: a => a.Id == deleteAsyncCourseRequest.Id);
            await _asyncCourseDal.DeleteAsync(removeAsyncCourse);
            DeletedAsyncCourseResponse deletedAsyncCourseResponse = _mapper.Map<DeletedAsyncCourseResponse>(deleteAsyncCourseRequest);
            return deletedAsyncCourseResponse;
        }

        public async Task<GetByIdAsyncCourseResponse> GetByIdAsync(Guid id)
        {
            var data = await _asyncCourseDal.GetAsync(
                predicate: p => p.Id == id,
                include: p => p.Include(p => p.Category
                ));

            var result = _mapper.Map<GetByIdAsyncCourseResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListAsyncCourseResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _asyncCourseDal.GetListAsync(include: p => p.Include(p => p.Category),
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAsyncCourseResponse>>(data);
            return result;
        }

        public async Task<UpdatedAsyncCourseResponse> UpdateAsync(UpdateAsyncCourseRequest updateAsyncCourseRequest)
        {
            AsyncCourse updateAsyncCourse = await _asyncCourseDal.GetAsync(p => p.Id == updateAsyncCourseRequest.Id);

            _mapper.Map(updateAsyncCourseRequest, updateAsyncCourse);

            AsyncCourse updatedAnnouncement = await _asyncCourseDal.UpdateAsync(updateAsyncCourse);

            UpdatedAsyncCourseResponse updatedAsyncCourseResponse = _mapper.Map<UpdatedAsyncCourseResponse>(updatedAnnouncement);

            return updatedAsyncCourseResponse;
        }
    }
}
