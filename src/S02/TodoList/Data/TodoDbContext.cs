using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data;
public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }
    public DbSet<User> Users {get;set;}
    public DbSet<TodoTask> TodoTasks {get;set;}
}