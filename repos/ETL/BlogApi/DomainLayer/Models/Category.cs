﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Category : BaseModel
    {
        
        public string? Description { get; set; }

        public string? Name { get; set; }

    }
}
