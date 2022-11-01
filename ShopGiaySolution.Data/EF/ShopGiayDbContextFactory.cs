using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Data.EF
{
    public class ShopGiayDbContextFactory : IDesignTimeDbContextFactory<ShopGiaydbContext>
    {
        public ShopGiaydbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsetings.json")
                  .Build();

            var connectionString = configuration.GetConnectionString("ShopGiaySolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopGiaydbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopGiaydbContext(optionsBuilder.Options);
        }
    }
}
