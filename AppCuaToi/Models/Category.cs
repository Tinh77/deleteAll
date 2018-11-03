using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppCuaToi.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Product> ListProduct { get; set; }
        public String createAt { get; set; }
        public String updateAt { get; set; }
    }
}
