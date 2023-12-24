namespace Business.Dtos.Experience.Request;

public class CreateExperienceRequest
{
    public Guid StudentId { get; set; }
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public string Sector { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndedDate { get; set; }
    public string JobDescription { get; set; }
    public string City { get; set; }
    public bool IsContinue { get; set; }
}