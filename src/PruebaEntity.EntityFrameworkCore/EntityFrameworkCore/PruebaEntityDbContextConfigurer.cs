using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PruebaEntity.EntityFrameworkCore
{
    public static class PruebaEntityDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PruebaEntityDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PruebaEntityDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
