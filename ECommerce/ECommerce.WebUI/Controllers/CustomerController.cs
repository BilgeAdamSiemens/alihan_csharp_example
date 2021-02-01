using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CustomerController(ICustomerRepository customerRepository, IWebHostEnvironment webHostEnvironment)
        {
            _customerRepository = customerRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List(int? page, int? size)
        {

            List<int> pageOptions = new List<int>
            {
                5, 10, 15
            };

            ViewBag.PageOptions = pageOptions;

            if(page == null )
            {
                page = 0;
            }

            if(size == null)
            {
                size = 5;
            }

            ViewBag.PageNumber = page.Value;
            ViewBag.PageSize = size.Value;
            ViewBag.TotalCustomer = _customerRepository.FindAll().Count;

            ViewBag.HowManyPage = ViewBag.TotalCustomer / size.Value;
            if (ViewBag.TotalCustomer % 5 != 0)
                ViewBag.HowManyPage += 1;

            Pageable pageable = new Pageable
            {
                Page = page.Value,
                Size = size.Value
            };

            List<Customer> customers = _customerRepository.FindAll(pageable);

            return View(customers);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Customer customer, IFormFile file)
        {
            if(file != null)
            {
                String imageName = Guid.NewGuid().ToString() + file.FileName;

                customer.ImageUrl = imageName;

                String fullPath = _webHostEnvironment.WebRootPath + "/img/customer/" + imageName;

                using(FileStream fs = System.IO.File.Create(fullPath))
                {
                    await file.CopyToAsync(fs);
                }

                


            }


            customer.IsActive = true;
            customer.LastOrder = null;
            customer.Orders = new List<Order>();
            
            _customerRepository.Save(customer);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _customerRepository.DeleteById(id);

            return RedirectToAction("List");
        }

        public IActionResult Form(int? id)
        {
            Customer customer = null;
            if(id == null)
                 customer = new Customer();
            else
            {
                customer = _customerRepository.FindById(id.Value);
            }


            return View(customer);
        }
    }
}
