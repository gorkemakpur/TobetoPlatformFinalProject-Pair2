namespace Business.Dtos.SocialMedia.Request
{
    public class UpdateSocialMediaRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SocialMediaNameId { get; set; }
        public string Url { get; set; }
    }

}
