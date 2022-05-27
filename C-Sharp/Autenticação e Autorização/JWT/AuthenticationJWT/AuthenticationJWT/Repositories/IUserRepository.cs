using AuthenticationJWT.Dto;
using AuthenticationJWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationJWT.Repositories
{
    public interface IUserRepository
    {
        UserDTO GetUser(User userMode);
    }
}
