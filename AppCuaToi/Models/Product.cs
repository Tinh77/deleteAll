using System;
using System.Collections.Generic;
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
        public String memberId { get; set; }
        public String createAt { get; set; }
        public String updateAt { get; set; }
    }
}
