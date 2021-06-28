using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }  
        public string Rating { get; set; }
    }
}
