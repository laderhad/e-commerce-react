using API.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductController:ControllerBase{

    [HttpGet]
    public IActionResult GetProducts(){
        return Ok(new List<Product> { 
            new Product { 
            Id = 1, 
            Name = "iPhone 15", 
            Description = "Apple iPhone 15, 128GB, Black", 
            ImageUrl = "iphone15.jpg", 
            Price = 600, 
            IsActive = true, 
            Stock = 100 },

            new Product { 
            Id = 2, 
            Name = "iPhone 16", 
            Description = "Apple iPhone 16, 128GB, Black", 
            ImageUrl = "iphone16.jpg", 
            Price = 800, 
            IsActive = true, 
            Stock = 100
            }
        });
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id){
        return Ok(new Product { 
            Id = 1, 
            Name = "iPhone 15", 
            Description = "Apple iPhone 15, 128GB, Black", 
            ImageUrl = "iphone15.jpg", 
            Price = 600, 
            IsActive = true, 
            Stock = 100 }
        );
    }
}