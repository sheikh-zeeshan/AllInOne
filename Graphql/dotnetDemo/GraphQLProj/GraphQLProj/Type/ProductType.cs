using GraphQL.Types;
using GraphQLProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProj.Type
{
    public class ProductType : ObjectGraphType<Product>
    {

        public ProductType()
        {
            Field(p=>p.Id);
            Field(x => x.Name);
            Field(x => x.Price);

        }

    }

}
