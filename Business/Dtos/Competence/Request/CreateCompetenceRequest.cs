namespace Business.Dtos.Competence.Request;

public class CreateCompetenceRequest
{
    public Guid StudentId { get; set; }
    public string Name { get; set; }
}