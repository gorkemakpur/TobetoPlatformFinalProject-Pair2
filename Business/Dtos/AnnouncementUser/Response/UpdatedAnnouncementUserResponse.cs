namespace Business.Dtos.AnnouncementUser.Response;

public class UpdatedAnnouncementUserResponse
{
    public Guid Id { get; set; }
    public Guid AnnouncementId { get; set; }
    public Guid UserId { get; set; }
    public bool IsRead { get; set; }
}