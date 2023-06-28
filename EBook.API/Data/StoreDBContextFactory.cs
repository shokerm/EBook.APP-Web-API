using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace EBook.API.Data
{

    public class StoreDBContextFactory : IDesignTimeDbContextFactory<StoreDBContext>
    {

        StoreDBContext IDesignTimeDbContextFactory<StoreDBContext>.CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .Build();

            DbContextOptionsBuilder<StoreDBContext> optionsBuilder = new();
            var conn = config.GetConnectionString("ConnectionString");
            optionsBuilder.UseSqlServer(conn);

            return new StoreDBContext(optionsBuilder.Options);
        }
    }
}
