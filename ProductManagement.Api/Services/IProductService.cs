using ProductManagement.Api.DTOs;
using ProductManagement.Api.Models;

namespace ProductManagement.Api.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task<Product> CreateAsync(CreateProductDto dto);

    Task<Product?> UpdateAsync(int id, UpdateProductDto dto);

    Task<bool> DeleteAsync(int id);
}