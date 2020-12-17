using GraphQLProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProj.Interfaces
{
    public interface IProduct
    {

        List<Product> GetAllProducts();
        Product AddProduct(Product p);

        Product UpdateProduct(int id , Product p);

        void DeleteProduct(int id);

        Product GetProductById(int id);


    }
}
