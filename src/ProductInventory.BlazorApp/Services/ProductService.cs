using ProductInventory.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductInventory.BlazorApp.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public async Task<Product> AddProduct(Product product)
        {
            var productJson = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/product", productJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Product>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteProduct(int productId)
        {
            await _httpClient.DeleteAsync($"api/product/{productId}");
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Product>>
                    (await _httpClient.GetStreamAsync($"api/product"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Product> GetProduct(int productId)
        {
            return await JsonSerializer.DeserializeAsync<Product>
               (await _httpClient.GetStreamAsync($"api/product/{productId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateProduct(Product product)
        {
            var productJson = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/product", productJson);
        }
    }
}
