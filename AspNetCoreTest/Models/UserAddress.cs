using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTest.Models
{
    public class UserAddress : BaseEntity
    {

        [ForeignKey("UserForeignKey")]
        public User User { get; set; }

        public string AddressName { get; set; }
        public bool ShouldMail { get; set; }
    }
}
