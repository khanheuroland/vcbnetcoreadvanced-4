using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vcbmain.Models;
using vcbmain.Repository;

namespace vcbmain.Services
{
    public interface IProductService
    {
        List<Product> SearchProduct(String keyword);
    }
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Product> SearchProduct(string keyword)
        {
            List<Product> allProduct = productRepository.All();
            return allProduct.Where(p=>p.Name.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}