using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTest.Services;
using AspNetCoreTest.Models;

namespace AspNetCoreTest.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _users;

        public UserService(IRepository<User> users)
        {
            this._users = users;
        }

        public User GetUserById(int id)
        {
            return _users.Get().Where(u => u.Id == id).FirstOrDefault();
        }
    }
}
