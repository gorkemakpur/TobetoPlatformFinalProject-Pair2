using AutoMapper;
using Business.Abstracts;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Business.Dtos.AsyncCourseContent.Request;
using Business.Dtos.AsyncCourseContent.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class AsyncCourseContentManager : IAsyncCourseContentService
    {
        private readonly IAsyncCourseContentDal _asyncCourseContentDal;
        private readonly IMapper _mapper;

        public AsyncCourseContentManager(IAsyncCourseContentDal asyncCourseContentDal, IMapper mapper)
        {
            _asyncCourseContentDal = asyncCourseContentDal;
            _mapper = mapper;
        }

        public async Task<CreatedAsyncCourseContentResponse> AddAsync(CreateAsyncCourseContentRequest createAsyncCourseContentRequest)
        {
            AsyncCourseContent addAsyncCourseContent = _mapper.Map<AsyncCourseContent>(createAsyncCourseContentRequest);
            AsyncCourseContent createdAsyncCourseContentResponse = await _asyncCourseContentDal.AddAsync(addAsyncCourseContent);
            CreatedAsyncCourseContentResponse createdAsyncCourseContent = _mapper.Map<CreatedAsyncCourseContentResponse>(createdAsyncCourseContentResponse);
            return createdAsyncCourseContent;
        }

        public async Task<DeletedAsyncCourseContentResponse> DeleteAsync(DeleteAsyncCourseContentRequest deleteAsyncCourseContentRequest)
        {
            AsyncCourseContent removeAsyncCourseContent = await _asyncCourseContentDal.GetAsync(predicate: a => a.Id == deleteAsyncCourseContentRequest.Id);
            await _asyncCourseContentDal.DeleteAsync(removeAsyncCourseContent);
            DeletedAsyncCourseContentResponse deletedAsyncCourseContentResponse = _mapper.Map<DeletedAsyncCourseContentResponse>(deleteAsyncCourseContentRequest);
            return deletedAsyncCourseContentResponse;
        }

        public async Task<IPaginate<GetListAsyncCourseContentResponse>> GetByAsynCourseId(Guid id)
        {
            var data = await _asyncCourseContentDal.GetListAsync(
                            index: 0,
                            size: 10,
                            predicate: p => p.AsyncCourseId == id,
                            include: p => p.Include(p => p.AsyncCourse)
                           );

            var result = _mapper.Map<Paginate<GetListAsyncCourseContentResponse>>(data);
            //var result = _mapper.Map<Paginate<GetByAsyncCourseIdResponse>>(data); normali bu şekilde ama profile de çalışmıyor düzelmezse üstteki gibi devam edicez
            return result;
        }

        public async Task<IPaginate<GetListAsyncCourseContentResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _asyncCourseContentDal.GetListAsync(
                                    index: 0,//pageRequest.PageIndex,
                                    size: 10 //pageRequest.PageSize
                                );

            var result = _mapper.Map<Paginate<GetListAsyncCourseContentResponse>>(data);
            return result;
        }
        public async Task<GetByIdAsyncCourseContentResponse> GetByIdAsync(Guid id)
        {
            var data = await _asyncCourseContentDal.GetAsync(
                            predicate: p => p.Id == id,
                            include: p => p.Include(p => p.Category
                            ));

            var result = _mapper.Map<GetByIdAsyncCourseContentResponse>(data);
            return result;
        }

     

        public async Task<UpdatedAsyncCourseContentResponse> UpdateAsync(UpdateAsyncCourseContentRequest updateAsyncCourseContentRequest)
        {
            AsyncCourseContent updateAsyncCourseContent = await _asyncCourseContentDal.GetAsync(p => p.Id == updateAsyncCourseContentRequest.Id);

            _mapper.Map(updateAsyncCourseContentRequest, updateAsyncCourseContent);

            AsyncCourseContent updatedAnnouncement = await _asyncCourseContentDal.UpdateAsync(updateAsyncCourseContent);

            UpdatedAsyncCourseContentResponse updatedAsyncCourseContentResponse = _mapper.Map<UpdatedAsyncCourseContentResponse>(updatedAnnouncement);

            return updatedAsyncCourseContentResponse;
        }
    }

}
