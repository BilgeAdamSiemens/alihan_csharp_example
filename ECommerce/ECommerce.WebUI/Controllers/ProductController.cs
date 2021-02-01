using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class ProductController : Controller
    {

        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            List<Product> products = _productRepository.FindAll();

            return View(products);
        }

        public IActionResult Detail(int id)
        {
            Product product = _productRepository.FindById(id);

            return View(product);
        }




    }
}
