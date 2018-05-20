using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTest.Models;

namespace AspNetCoreTest.Models
{
    public class AspContext : DbContext
    {
        public AspContext(DbContextOptions<AspContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<GenericAttribute> GenericAttributes { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
