namespace Business.Dtos.AsyncCourse.Response
{
    public class GetListAsyncCourseResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
    }
}
