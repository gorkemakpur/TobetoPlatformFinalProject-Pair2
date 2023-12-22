namespace Business.Dtos.Student.Response;

public class CreatedStudentResponse
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid UserId { get; set; }
}
