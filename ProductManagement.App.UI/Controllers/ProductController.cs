using Microsoft.AspNetCore.Mvc;
using ProductManagement.App.UI.Models.APIModels;
using ProductManagement.App.UI.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.App.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductProvider _pProvider;

        public ProductController(ProductProvider pProvider)
        {
            _pProvider = pProvider;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetProducts(int id)
        
        {
            IEnumerable<ProductsWithCategoryDTO> values= await _pProvider.getProductByCategoryId(id);
            return View(values);
        }
    }
}
