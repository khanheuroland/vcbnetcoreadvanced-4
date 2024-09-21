using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using vcbmain.Models;
using vcbmain.Repository;
using vcbmain.Services;

namespace vcbtest.Services
{
    
    public class ProductServiceTest
    {
        private ProductService serviceUnderTest;
        public ProductServiceTest()
        {
            
        }

        [Fact]
        public void should_return_blank_result_list_for_no_proudct_from_repository()
        {
            var moqProductRepository = new Mock<IProductRepository>();
            moqProductRepository.Setup(m=>m.All()).Returns(new List<Product>());
            this.serviceUnderTest = new ProductService(moqProductRepository.Object);
            
            List<Product> lstResult = this.serviceUnderTest.SearchProduct("iPhone");

            //Assert
            Assert.Equal(lstResult, new List<Product>());
        }

        [Fact]
        public void should_return_result_list_for_1_proudct_matched_from_repository()
        {
            List<Product> lstProduct = new List<Product>(){
                new Product(){Id = 1, Name = "Apple iPhone 16", Price=25000000}
            };
            var moqProductRepository = new Mock<IProductRepository>();
            moqProductRepository.Setup(m=>m.All()).Returns(lstProduct);
            this.serviceUnderTest = new ProductService(moqProductRepository.Object);
            
            List<Product> lstResult = this.serviceUnderTest.SearchProduct("iPhone");

            //Assert
            Assert.Equal(lstProduct, lstResult);
        }

        [Fact]
        public void should_return_blank_result_list_for_0_proudct_matched_from_repository()
        {
            List<Product> lstProduct = new List<Product>(){
                new Product(){Id = 1, Name = "Apple iPhone 16", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Plus", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Pro", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Promax", Price=25000000}
            };
            var moqProductRepository = new Mock<IProductRepository>();
            moqProductRepository.Setup(m=>m.All()).Returns(lstProduct);
            this.serviceUnderTest = new ProductService(moqProductRepository.Object);
            
            List<Product> lstResult = this.serviceUnderTest.SearchProduct("samsung");

            //Assert
            Assert.Equal(new List<Product>(), lstResult);
        }

        [Fact]
        public void should_return_result_list_for_4_product_matched_from_repository_with_keyword()
        {
            List<Product> lstProduct = new List<Product>(){
                new Product(){Id = 1, Name = "Apple iPhone 16", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Plus", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Pro", Price=25000000},
                new Product(){Id = 1, Name = "Apple iPhone 16 Promax", Price=25000000}
            };
            var moqProductRepository = new Mock<IProductRepository>();
            moqProductRepository.Setup(m=>m.All()).Returns(lstProduct);
            this.serviceUnderTest = new ProductService(moqProductRepository.Object);
            
            List<Product> lstResult = this.serviceUnderTest.SearchProduct("IphOne");

            //Assert
            Assert.Equal(lstProduct, lstResult);
        }
    }
}