﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireApp.Model.Entities
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

    }
}
