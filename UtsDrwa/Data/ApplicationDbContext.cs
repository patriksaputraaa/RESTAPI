using Microsoft.EntityFrameworkCore;
using UTS-DRWA.Models;

namespace UTS-DRWA.Data;

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){
        
    }
    
    public DbSet<User> Users{get; set;}
    // public DbSet<Post> Posts{get; set;}
    // public DbSet<Student> Students{get; set;}
    // public DbSet<Course> Courses{get; set;}
}