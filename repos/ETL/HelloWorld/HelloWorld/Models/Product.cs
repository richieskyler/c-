﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Product
    {
        public int id { get; set; }

        public string Name { get; set; }
        public string Desciprion { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        //Navigation Property

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}
