using GraphQLProj.Interfaces;
using GraphQLProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProj.Services
{
    public class ProductService : IProduct
    {

        static List<Product> products = new List<Product> { 
            new Product {Id=1, Name="1", Price=33.44 },
            new Product { Id=2, Name="List ddd", Price=33.44 }

        };
        public Product AddProduct(Product p)
        {
            products.Add(p);
            return p;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(x => x.Id == id);
        }

        public Product UpdateProduct(int id, Product p)
        {
            products[id] = p;
            return p;
        }
    }
}
