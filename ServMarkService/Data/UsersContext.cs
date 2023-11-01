using Microsoft.EntityFrameworkCore;
using ServMarkService.Models;

namespace ServMarkService.Data;

public class UsersContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Users
        var usersInit = new List<User>()
        {
            new ()
            {
                Id = 1,
                Email = "john@mail.com",
                Password = "changeme",
                Name = "Jhon",
                Role = "customer"
            },
            new ()
            {
                Id = 2,
                Email = "maria@mail.com",
                Password = "12345",
                Name = "Maria",
                Role = "customer"
            },
            new ()
            {
                Id = 3,
                Email = "admin@mail.com",
                Password = "admin123",
                Name = "Admin",
                Role = "admin"
            }
        };
        
        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("User");
            user.HasKey(p => p.Id);
            user.Property(p => p.Id).UseIdentityColumn();
            user.Property(p => p.Email).IsRequired().HasMaxLength(150);
            user.Property(p => p.Name).IsRequired().HasMaxLength(150);
            user.Property(p => p.Password).IsRequired().HasMaxLength(150);
            user.Property(p => p.Role).IsRequired().HasMaxLength(150);
            user.HasData(usersInit);
        });
        #endregion
    }
}