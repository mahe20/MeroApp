using LoginApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options){}
        
        public DbSet<User> Users {get;set;}
    }
}