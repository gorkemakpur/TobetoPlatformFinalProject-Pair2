namespace Business.Dtos.Language.Request;

public class UpdateLanguageRequest
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid LanguageLevelId { get; set; }
    public Guid LanguageTypeId { get; set; }
}
