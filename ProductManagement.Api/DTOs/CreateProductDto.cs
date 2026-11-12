using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Api.DTOs;

public class CreateProductDto
{
    [Required(ErrorMessage = "Product name is required")]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 1000000)]
    public decimal Price { get; set; }
}