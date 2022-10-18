using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BTL_CNPM.EntityFrameworkCore
{
    public static class BTL_CNPMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BTL_CNPMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BTL_CNPMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
