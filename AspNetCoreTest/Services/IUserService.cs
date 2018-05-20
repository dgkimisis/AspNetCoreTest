using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTest.Models;

namespace AspNetCoreTest.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
    }
}
