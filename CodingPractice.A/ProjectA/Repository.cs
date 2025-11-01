using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<List<Product>> GetAllProductsAsync();
        Task<bool> UpdateStockAsync(int productId, int quantity);
    }

    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public InMemoryProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Stock = 10 },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Stock = 25 },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m, Stock = 15 }
            };
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            return Task.FromResult(_products);
        }

        public Task<bool> UpdateStockAsync(int productId, int quantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null || product.Stock < quantity)
            {
                return Task.FromResult(false);
            }
            product.Stock -= quantity;
            return Task.FromResult(true);
        }
    }
}
