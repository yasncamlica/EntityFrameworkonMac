using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkCore2.Models;

namespace EntityFrameworkCore2.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult List() => View(repository.Products);
    }
}