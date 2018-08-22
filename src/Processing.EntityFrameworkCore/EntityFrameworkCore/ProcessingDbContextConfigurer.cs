using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Processing.EntityFrameworkCore
{
    public static class ProcessingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProcessingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProcessingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
