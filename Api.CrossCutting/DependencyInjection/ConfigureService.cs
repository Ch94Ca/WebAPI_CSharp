using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenceService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();

        }
    }
}
