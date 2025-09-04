using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, Assembly handlersAssembly)
        {
            services.AddSingleton<IMediator, Mediator>();
            services.Scan(scan => scan
                .FromAssemblies(handlersAssembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IRequestHandler<,>)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
            return services;
        }
    }
}
