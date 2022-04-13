using Microsoft.AspNetCore.Mvc;
using ProductManagement.App.UI.Models.APIModels;
using ProductManagement.App.UI.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.App.UI.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly CategoryProvider _provider;

        public CategoryViewComponent(CategoryProvider provider)
        {
            _provider = provider;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<CategoryDTO> values= await _provider.GetCategories();
            return View(values);
        }
    }
}
