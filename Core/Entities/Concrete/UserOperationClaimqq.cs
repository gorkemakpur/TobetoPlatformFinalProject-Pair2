using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    //normalde buradaki entity'i kullanırdık fakat proje ilerlediği için bozmak istemedim o yüzden ismini değiştiriyorum
    //proje erken biterse bu kısmı uyarlayabiliriz
    public class UserOperationClaimqq //:IEntity
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
