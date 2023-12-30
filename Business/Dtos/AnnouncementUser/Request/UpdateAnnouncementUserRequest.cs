namespace Business.Dtos.AnnouncementUser.Request;

public class UpdateAnnouncementUserRequest
{
    public Guid Id { get; set; }
    public Guid AnnouncementId { get; set; }
    public Guid UserId { get; set; }
    public bool IsRead { get; set; }
}