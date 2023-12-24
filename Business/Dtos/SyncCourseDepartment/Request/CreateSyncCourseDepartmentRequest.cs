namespace Business.Dtos.SyncCourseDepartment.Request;

public class CreateSyncCourseDepartmentRequest
{
    public Guid DepartmentId { get; set; }
    public Guid SyncCourseId { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndedDate { get; set; }
}