/*
 *Carlos Fernandez Jimenez
 *Products service logic
 *Based on Professional ASP.NET Design Patterns Book
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.Model;
using api.Domain.Interface;

namespace api.Domain
{
    public class ProductService : IProductService
    {
       // private IProductRepository _productRepository;

        public ProductService()//(IProductRepository productRepository)
        {
            //_productRepository = productRepository;
        }

        public IList<Product> GetAllProductsFor(int type)
        {
            IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyFor(type);//(customerType);
            IList<Product> products = new List<Product>();
            products.Add(new Product(){ Name = "Helado", Price = new Price(1000, 20) });

            //IList<Product> products = _productRepository.FindAll();

            products.Apply(discountStrategy);

            return products;
        }
    }
}