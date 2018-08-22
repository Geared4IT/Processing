using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Processing.Configuration;
using Processing.Web;

namespace Processing.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProcessingDbContextFactory : IDesignTimeDbContextFactory<ProcessingDbContext>
    {
        public ProcessingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProcessingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProcessingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProcessingConsts.ConnectionStringName));

            return new ProcessingDbContext(builder.Options);
        }
    }
}
