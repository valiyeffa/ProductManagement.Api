using ProductManagement.Api.Models;

namespace ProductManagement.Api.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task AddAsync(Product product);

    Task UpdateAsync(Product product);

    Task<bool> DeleteAsync(int id);
}