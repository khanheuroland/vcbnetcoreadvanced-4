using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vcbmain.Models;

namespace vcbmain.Repository
{
    public interface IProductRepository
    {
        public List<Product> All();
    }
    public class ProductRepository:IProductRepository
    {
        public List<Product> All()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(){Id=1, Name="iPhone 16", Price=21000000});
            products.Add(new Product(){Id=2, Name="iPhone 16 Plus", Price=25000000});
            products.Add(new Product(){Id=3, Name="iPhone 16 Pro", Price=30000000});
            products.Add(new Product(){Id=4, Name="iPhone 16 Promax", Price=40000000});

            products.Add(new Product(){Id=5, Name="Samsung S24", Price=24000000});
            products.Add(new Product(){Id=5, Name="Samsung S24ultra", Price=34000000});

            return products;
        }
    }
}