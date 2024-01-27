namespace Business.Dtos.UserOperationClaim.Response;

public class GetByIdUserOperationClaimResponse
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public int OperationClaimId { get; set; }
}
