namespace Business.Dtos.SyncCourseDepartment.Response;

public class GetByIdSyncCourseDepartmentResponse
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid SyncCourseId { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndedDate { get; set; }
}