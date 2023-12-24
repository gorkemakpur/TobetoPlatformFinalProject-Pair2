namespace Business.Dtos.Department.Request;

public class UpdateDepartmentRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}