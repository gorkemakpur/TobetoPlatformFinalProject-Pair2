namespace Business.Dtos.SocialMedia.Response
{
    public class GetByIdSocialMediaResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SocialMediaNameId { get; set; }
        public string Url { get; set; }
    }

}
