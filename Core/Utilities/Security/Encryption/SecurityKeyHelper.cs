using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //verdiğimiz security keyi byte array haline getiriyor appdevelopment
        public static SecurityKey CreateSecurityKey(string security)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(security));
        }
    }
}
