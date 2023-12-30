namespace Business.Dtos.SyncCourse.Request
{
    public class UpdateSyncCourseRequest
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Subtype { get; set; }
    }
}
