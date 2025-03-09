using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ReceitaFederal.Infrastructure.Configurations
{
    public static class PresentationConfig
    {
        public static void AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.Load("ReceitaFederal.Services")));
        }
    }
}