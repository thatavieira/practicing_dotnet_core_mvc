using System.ComponentModel.DataAnnotations;

namespace PetShop.Models;

public class Products
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int Price { get; set; }
    
    [Required] 
    public int IdCategories { get; set; }

    public Products(int id, string name, string description, int price, int idCategories)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        IdCategories = idCategories;
    }

    public Products(string name, string description, int price, int idCategories)
    {
        Name = name;
        Description = description;
        Price = price;
        IdCategories = idCategories;
    }

    public Products()
    {
        
    }
    
}