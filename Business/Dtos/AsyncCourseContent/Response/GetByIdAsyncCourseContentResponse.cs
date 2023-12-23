namespace Business.Dtos.AsyncCourseContent.Response
{
    public class GetByIdAsyncCourseContentResponse
    {
        public Guid Id { get; set; }
        public Guid AsyncCourseId { get; set; }
        public string AsyncCourseName { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public string Subtype { get; set; }
        public string Producer { get; set; }
        public string Description { get; set; }
    }
}
