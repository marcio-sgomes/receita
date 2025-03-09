using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReceitaFederal.Infrastructure.Persistence.Contexts;

namespace ReceitaFederal.Infrastructure.Configurations
{
    public static class PersistenceConfig
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ReceitaFederalContext>(opt 
                => opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}