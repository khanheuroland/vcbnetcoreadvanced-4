using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using vcbmain.Controllers.Api;
using vcbmain.Models;
using vcbmain.Services;

namespace vcbtest.Controllers.Api
{
    public class ProductControllerTest
    {
        private ProductController _controller;
        private Mock<IProductService> _mockProductService;
        public ProductControllerTest(){
            
        }

        [Fact]
        public async void Return_Json_Result_with_searched_proudct_list()
        {
            List<Product> products = new List<Product>(){
                new Product { Id = 1, Name="iPhone", Price = 25000000}
            };

            _mockProductService = new Mock<IProductService>();
            _mockProductService.Setup(p=>p.SearchProduct("iPhone")).Returns(products);

            _controller = new ProductController(_mockProductService.Object);
            //Act
            var response = _controller.SearchProduct("iPhone");

            var searchActionResult = Assert.IsType<OkObjectResult>(response);

            Assert.Equal(products, searchActionResult.Value);
        }
    }
}