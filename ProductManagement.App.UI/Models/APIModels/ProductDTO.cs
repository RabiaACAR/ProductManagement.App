﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.App.UI.Models.APIModels
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public bool isActive { get; set; }
    }
}
