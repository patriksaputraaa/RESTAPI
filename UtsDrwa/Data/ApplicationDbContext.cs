using Microsoft.EntityFrameworkCore;
using UtsDrwa.Models;

namespace UtsDrwa.Data;

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){
        
    }
    
    public DbSet<User> Users{get; set;}
    // public DbSet<Post> Posts{get; set;}
    // public DbSet<Student> Students{get; set;}
    // public DbSet<Course> Courses{get; set;}
}