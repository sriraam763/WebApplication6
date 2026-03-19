using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data;

public class ApplicationDbContext:IdentityDbContext
{
    public DbSet<TaskList> TaskLists { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
}