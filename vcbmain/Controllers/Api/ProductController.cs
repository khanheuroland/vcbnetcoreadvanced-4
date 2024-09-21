using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vcbmain.Models;
using vcbmain.Services;

namespace vcbmain.Controllers.Api
{
    public class ProductController : ControllerBase
    {
        IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult SearchProduct(String keyword)
        {
            List<Product> lstResult = productService.SearchProduct(keyword);
            return Ok(lstResult);
        }

    }
}