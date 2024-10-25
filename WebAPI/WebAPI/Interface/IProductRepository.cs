using System;
using WebAPI.Models;

namespace WebAPI.Interface
{
	public interface IProductRepository
	{
        Task<IEnumerable<Products>> GetAllProductsAsync();
        Task<Products> GetProductByIdAsync(int id);
        Task AddProductAsync(Products product);
        Task UpdateProductAsync(Products product);
        Task DeleteProductAsync(int id);
    }
}

