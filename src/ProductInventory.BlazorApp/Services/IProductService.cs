using ProductInventory.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory.BlazorApp.Services
{
    /// <summary>
    /// -- Get all Products
    /// -- Get Product Item by ID
    /// -- Delete Item by ID
    /// -- Add Product 
    /// -- Update Product
    /// </summary>
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int productId);
        Task<Product> AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int product);
    }
}
