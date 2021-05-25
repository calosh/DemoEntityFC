using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PruebaEntity.Configuration;
using PruebaEntity.Web;

namespace PruebaEntity.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PruebaEntityDbContextFactory : IDesignTimeDbContextFactory<PruebaEntityDbContext>
    {
        public PruebaEntityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PruebaEntityDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PruebaEntityDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PruebaEntityConsts.ConnectionStringName));

            return new PruebaEntityDbContext(builder.Options);
        }
    }
}
