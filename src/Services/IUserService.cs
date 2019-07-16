using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IUserService
    {
         User Authenticate(string username, string password);
         IEnumerable<User> GetAll();
    }
}