namespace Business.Dtos.Competence.Request;

public class UpdateCompetenceRequest
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string Name { get; set; }
}