using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //const string connectionString = "Server=localhost;Port=3306;Database=Web_API;Uid=Dev;Pwd=1234AbCd";
            //var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(connectionString);

            const string connectionString = "Server=localhost;Initial Catalog=Db_Web_API;MultipleActiveResultSets=false;User ID=Dev;Password=1234AbCd";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
