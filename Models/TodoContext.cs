/*Create the database context

The databse context is the main class that coordinates Entity Frameswork 
functionality for a given model. You create this class by deriving from the 
`Microsoft.EntityFramworkCore.DbContext` class

Add a `TodoContext` class in the Models folder*/

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    { 
        public TodoContext (DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems {get; set;}
    }

}