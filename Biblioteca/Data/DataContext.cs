using Biblioteca.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Book>  Books { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
