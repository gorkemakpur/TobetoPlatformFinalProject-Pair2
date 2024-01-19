using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //apinin gelen jwt yi doğrulaması gerektiği için bu kısımı kullanıyoruz
        //sisteme girdiğin username ve parola bir credential örneği
        public static SigningCredentials CreateSigningCredentials(SecurityKey security) 
        {
            return new SigningCredentials(security,SecurityAlgorithms.HmacSha512);
        }
    }
}
