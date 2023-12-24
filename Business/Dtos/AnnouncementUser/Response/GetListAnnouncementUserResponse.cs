namespace Business.Dtos.AnnouncementUser.Response;

public class GetListAnnouncementUserResponse
{
    public Guid Id { get; set; }
    public Guid AnnouncementId { get; set; }
    public Guid UserId { get; set; }
    public bool IsRead { get; set; }
}