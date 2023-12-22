namespace Business.Dtos.Student.Request;

public class UpdateStudentRequest
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid UserId { get; set; }
}
