namespace Business.Dtos.UserOperationClaim.Request;

public class UpdateUserOperationClaimRequest
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public int OperationClaimId { get; set; }
}
