namespace Business.Dtos.AnnouncementUser.Request;

public class CreateAnnouncementUserRequest
{
    public Guid AnnouncementId { get; set; }
    public Guid UserId { get; set; }
    public bool IsRead { get; set; }
}