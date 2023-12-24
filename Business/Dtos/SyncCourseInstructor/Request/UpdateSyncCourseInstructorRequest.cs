namespace Business.Dtos.SyncCourseInstructor.Request;

public class UpdateSyncCourseInstructorRequest
{
    public Guid Id { get; set; }
    public Guid SyncCourseContentId { get; set; }
    public Guid InstructorId { get; set; }
}