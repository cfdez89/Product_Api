using System.Collections.Generic;
using api.Model;

namespace api.Domain.Interface
{
    public interface IProductService
    {
        IList<Product> GetAllProductsFor(int type);//(CustomerType customerType)
       
    }
}