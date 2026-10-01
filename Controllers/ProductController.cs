using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCatalogApplication.Models;

namespace ProductCatalogApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }
        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductID == id);

            return View(P1);
        }
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Mobile",
                    Description = "Dell Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 3000,
                    Category = "Accessories"
                }
            };
        }
    }
}