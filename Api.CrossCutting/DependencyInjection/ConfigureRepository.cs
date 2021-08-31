using Microsoft.Extensions.DependencyInjection;
using Data.Repository;
using Domain.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Domain.Repository;
using Data.Implementations;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenceRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<MyContext>
            (
                options => options.UseMySql("Server=localhost;Port=3306;Database=WebAPI;Uid=Dev;Pwd=1234AbCd")
            );
        }
    }
}
