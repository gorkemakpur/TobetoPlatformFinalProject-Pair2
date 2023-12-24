namespace Business.Dtos.SyncCourseInstructor.Response;

public class GetByIdSyncCourseInstructorResponse
{
    public Guid Id { get; set; }
    public Guid SyncCourseContentId { get; set; }
    public Guid InstructorId { get; set; }
}