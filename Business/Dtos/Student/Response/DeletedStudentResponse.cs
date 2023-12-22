namespace Business.Dtos.Student.Response;

public class DeletedStudentResponse
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid UserId { get; set; }
}
