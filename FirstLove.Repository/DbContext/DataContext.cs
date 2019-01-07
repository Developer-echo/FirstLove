using System;
using Microsoft.EntityFrameworkCore;

namespace FirstLove.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
    }
}