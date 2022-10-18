using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BTL_CNPM.Configuration;
using BTL_CNPM.Web;

namespace BTL_CNPM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BTL_CNPMDbContextFactory : IDesignTimeDbContextFactory<BTL_CNPMDbContext>
    {
        public BTL_CNPMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BTL_CNPMDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BTL_CNPMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BTL_CNPMConsts.ConnectionStringName));

            return new BTL_CNPMDbContext(builder.Options);
        }
    }
}
