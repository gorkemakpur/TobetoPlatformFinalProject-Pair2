namespace Business.Dtos.Department.Response;

public class GetByIdDepartmentResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}