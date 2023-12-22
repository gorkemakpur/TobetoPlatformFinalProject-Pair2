namespace Business.Dtos.Student.Response;

public class GetByIdStudentResponse
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid UserId { get; set; }
}
