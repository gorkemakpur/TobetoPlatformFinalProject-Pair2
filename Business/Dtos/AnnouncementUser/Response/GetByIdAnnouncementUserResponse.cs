namespace Business.Dtos.AnnouncementUser.Response;

public class GetByIdAnnouncementUserResponse
{
    public Guid Id { get; set; }
    public Guid AnnouncementId { get; set; }
    public Guid UserId { get; set; }
    public bool IsRead { get; set; }
}