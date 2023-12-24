namespace Business.Dtos.Language.Request;

public class CreateLanguageRequest
{
    public Guid StudentId { get; set; }
    public Guid LanguageLevelId { get; set; }
    public Guid LanguageTypeId { get; set; }
}
