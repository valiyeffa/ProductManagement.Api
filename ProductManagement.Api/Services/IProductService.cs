using ProductManagement.Api.DTOs;
using ProductManagement.Api.Models;

namespace ProductManagement.Api.Services;

public interface IProductService
{
    List<Product> GetAll();

    Product? GetById(int id);

    Product Create(CreateProductDto dto);

    Product? Update(int id, UpdateProductDto dto);

    bool Delete(int id);
}