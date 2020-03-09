using HappyCamp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HappyCamp.DataAccess.Context
{
    public class SQLServerContext : DbContext
    {
        internal DbSet<PersonEntity> Persons { get; set; }
        internal DbSet<RoleEntity> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C9M90RL\\SQLEXPRESS;Database=HappyCamp;Trusted_Connection=True");
        }
    }
}
