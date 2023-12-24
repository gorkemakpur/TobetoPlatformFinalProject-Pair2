namespace Business.Dtos.Competence.Response;

public class DeletedCompetenceResponse
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public string Name { get; set; }
}