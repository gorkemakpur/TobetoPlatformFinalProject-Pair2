namespace Business.Dtos.Student.Request;

public class CreateStudentRequest
{
    public Guid DepartmentId { get; set; }
    public Guid UserId { get; set; }
}
