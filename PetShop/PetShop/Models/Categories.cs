using System.ComponentModel.DataAnnotations;

namespace PetShop.Models;

public class Categories
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }


    public Categories(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Categories(string name)
    {
        Name = name;
    }

    public Categories()
    {
        
    }
    
}