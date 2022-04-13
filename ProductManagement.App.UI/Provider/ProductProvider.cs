using Newtonsoft.Json;
using ProductManagement.App.UI.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductManagement.App.UI.Provider
{
    public class ProductProvider
    {
        private readonly HttpClient _httpClient;

        public ProductProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductsWithCategoryDTO>> getProductByCategoryId(int id)
        {
            var assets = await _httpClient.GetAsync($"/api/Product/{id}");

            if (assets.IsSuccessStatusCode)
            {
                var assetsString = await assets.Content.ReadAsStringAsync();
                var assetsJson = JsonConvert.DeserializeObject<IEnumerable<ProductsWithCategoryDTO>>(assetsString);
                return assetsJson;
            }
            else
            {
                return null;
            }
        }

        
    }
}
