using AuthenticationJWT.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationJWT.Services
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        bool ValidateToken(string key, string issuer, string audience, string token);
    }
}
