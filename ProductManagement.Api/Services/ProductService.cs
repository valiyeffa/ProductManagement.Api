using ProductManagement.Api.DTOs;
using ProductManagement.Api.Models;

namespace ProductManagement.Api.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1500m },
        new Product { Id = 2, Name = "Mouse", Price = 35m }
    };

    public List<Product> GetAll()
    {
        return _products; 
    }

    public Product? GetById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        return product;
    }

    public Product Create(CreateProductDto dto)
    {
        var product = new Product
        {
            Id = _products.Max(p => p.Id) + 1,
            Name = dto.Name,
            Price = dto.Price
        };

        _products.Add(product);

        return product;
    }

    public Product? Update(int id, UpdateProductDto dto)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return null;
        }

        product.Name = dto.Name;
        product.Price = dto.Price;

        return product;
    }

    public bool Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return false;
        }

        _products.Remove(product);

        return true;
    }
}