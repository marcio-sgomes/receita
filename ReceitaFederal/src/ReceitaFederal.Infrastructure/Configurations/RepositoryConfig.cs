using Microsoft.Extensions.DependencyInjection;
using ReceitaFederal.Infrastructure.Repositories;
using ReceitaFederal.Infrastructure.Repositories.Contracts;

namespace ReceitaFederal.Infrastructure.Configurations;

public static class RepositoryConfig
{
    public static void AddRepository(this IServiceCollection services)
	{
		services.AddScoped<IEmpresaRepository, EmpresaRepository>();
    }
}
