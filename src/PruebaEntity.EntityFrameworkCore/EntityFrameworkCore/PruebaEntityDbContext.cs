using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PruebaEntity.Authorization.Roles;
using PruebaEntity.Authorization.Users;
using PruebaEntity.MultiTenancy;
using PruebaEntity.App.Productos;

namespace PruebaEntity.EntityFrameworkCore
{
    public class PruebaEntityDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaEntityDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Producto> Producto { set; get; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Nivel> Nivel { get; set; }


        public PruebaEntityDbContext(DbContextOptions<PruebaEntityDbContext> options)
            : base(options)
        {
        }

       

    }
}
