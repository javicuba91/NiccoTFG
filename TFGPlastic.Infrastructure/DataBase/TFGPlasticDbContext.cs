using Microsoft.EntityFrameworkCore;
using TFGPlastic.Core.Entity;
using TFGPlastic.Core.Entity.User.User;

namespace TFGPlastic.Infrastructure.DataBase
{
    public class TFGPlasticDbContext : DbContext
    {
        public TFGPlasticDbContext(DbContextOptions<TFGPlasticDbContext> options): base(options)
        {
        }
        public DbSet<TareaEntity> Tarea { get; set; }

       /* public DbSet<usuario> Users { get; set; }*/
    }
}