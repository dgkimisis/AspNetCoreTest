﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTest.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
