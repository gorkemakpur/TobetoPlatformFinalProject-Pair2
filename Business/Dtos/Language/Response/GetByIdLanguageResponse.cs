﻿namespace Business.Dtos.Language.Response;

public class GetByIdLanguageResponse
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid LanguageLevelId { get; set; }
    public Guid LanguageTypeId { get; set; }
}
