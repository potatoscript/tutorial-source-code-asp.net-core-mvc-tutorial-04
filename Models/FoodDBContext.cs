using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class FoodDBContext : DbContext
    {

        public IConfiguration _configuration;

        public FoodDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connstring = String.Format(
                _configuration
                .GetSection("ConnectionStrings")
                .GetSection("DbContextConnection").Value);

            optionsBuilder.UseNpgsql(connstring);

        }


    }
}
