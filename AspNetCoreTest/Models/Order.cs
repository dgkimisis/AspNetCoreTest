using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTest.Models
{
    public class Order : BaseEntity
    {
        //public int Id { get;set;}
        public string Name { get; set; }
        public decimal Total { get; set; }
    }
}
