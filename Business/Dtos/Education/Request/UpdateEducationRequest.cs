namespace Business.Dtos.Education.Request;

public class UpdateEducationRequest
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid SituationId { get; set; }
    public string University { get; set; }
    public string Department { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndedDate { get; set; }
    public bool IsContinue { get; set; }
}