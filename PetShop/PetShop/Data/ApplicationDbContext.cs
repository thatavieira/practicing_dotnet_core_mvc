using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}


    