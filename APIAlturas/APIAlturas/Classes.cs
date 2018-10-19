using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace APIAlturas
{
    public class User
    {
        public string UserID { get; set; }
        public string AccessKey { get; set; }
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }

    public class SigningConfigurations
    {
        public SigningConfigurations(string keyValue)
        {
            Key = keyValue;
        }

        public SecurityKey SecurityKey => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));

        public SigningCredentials SigningCredentials => new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha512);

        string Key { get; }
    }
}