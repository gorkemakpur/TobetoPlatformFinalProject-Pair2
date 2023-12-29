using Core.Entities;

namespace Entities.Concretes;

public class Role : Entity<Guid>
{
    public string Type { get; set; }
    public List<User>? Users { get; set; }
}
