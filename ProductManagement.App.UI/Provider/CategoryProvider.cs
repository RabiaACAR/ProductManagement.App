using Newtonsoft.Json;
using ProductManagement.App.UI.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductManagement.App.UI.Provider
{
    public class CategoryProvider
    {
        private readonly HttpClient _httpClient;

        public CategoryProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var values = await _httpClient.GetAsync("Category");
            if (values.IsSuccessStatusCode)
            {
                var detailsString = await values.Content.ReadAsStringAsync();
                var detailJson =  JsonConvert.DeserializeObject<IEnumerable<CategoryDTO>>(detailsString);
                return detailJson;

            }
            else
            {
               return null;
            }
        }
    }
}
