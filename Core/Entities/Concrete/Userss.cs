using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Userss //:IEntity
    {
        //normalde buradaki entity'i kullanırdık fakat proje ilerlediği için bozmak istemedim o yüzden ismini değiştiriyorum
        //proje erken biterse bu kısmı uyarlayabiliriz
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
