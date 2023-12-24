namespace Business.Dtos.SyncCourseDepartment.Request;

public class UpdateSyncCourseDepartmentRequest
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid SyncCourseId { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndedDate { get; set; }
}