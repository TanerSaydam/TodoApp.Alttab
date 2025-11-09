using Microsoft.EntityFrameworkCore;
using TodoApp.MVC.Models;

namespace TodoApp.MVC.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
}