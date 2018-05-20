using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTest.Models
{
    public class GenericAttribute : BaseEntity
    {
        [ForeignKey("BaseEntityForeignKey")]
        public int EntityId { get; set; }

        public string Key { get; set; }
        public string XMLValue { get; set; }
    }
}
