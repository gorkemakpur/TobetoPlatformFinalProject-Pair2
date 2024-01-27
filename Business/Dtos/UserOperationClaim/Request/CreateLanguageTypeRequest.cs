using Core.Entities.Concrete;

namespace Business.Dtos.UserOperationClaim.Request;

public class CreateUserOperationClaimRequest
{
    public Guid UserId { get; set; }
    public int OperationClaimId { get; set; }
}
