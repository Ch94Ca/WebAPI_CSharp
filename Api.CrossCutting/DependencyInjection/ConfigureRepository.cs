using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Repository;
using Domain.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenceRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MyContext>
            (
                options => options.UseMySql("Server=localhost;Port=3306;Database=WebAPI;Uid=Dev;Pwd=1234AbCd")
            );

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
