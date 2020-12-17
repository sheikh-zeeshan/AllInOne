using GraphQL;
using GraphQL.Types;
using GraphQLProj.Interfaces;
using GraphQLProj.Models;
using GraphQLProj.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProj.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProduct productService)
        {
            Field<ListGraphType<ProductType>>("Products", resolve: context => { return productService.GetAllProducts(); });

            Field<ProductType>("Product", arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name="id" }),
                resolve: context => { 
                    return productService.GetProductById(context.GetArgument<int>("id")); 
                });
            
        }
    }
}
