using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BookStoreApp.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
        new Product { BookName = "Harry Potter", AuthorName = "JK Rowling", Price = 25, Category = "Fantasy", Rating = "YA", Description = "Description 1",  },
        new Product { BookName = "Football", AuthorName = "JK Rowling", Price = 25, Category = "Fantasy", Rating = "YA", Description = "Description 1",  },
        new Product { BookName = "Another Book lol", AuthorName = "JK Rowling", Price = 25, Category = "Fantasy", Rating = "YA", Description = "Description 1",  }
    };
    }
}
