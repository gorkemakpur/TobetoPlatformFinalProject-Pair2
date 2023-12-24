namespace Business.Dtos.SyncCourseInstructor.Request;

public class CreateSyncCourseInstructorRequest
{
    public Guid SyncCourseContentId { get; set; }
    public Guid InstructorId { get; set; }
}