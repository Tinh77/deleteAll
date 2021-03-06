﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppCuaToi.Models
{
    public class Product
    {
        
        public long id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String thumbnail { get; set; }
        public long categoryId { get; set; }
        public Category Category { get; set; }
        public String createAt { get; set; }
        public String updateAt { get; set; }
    }
}
