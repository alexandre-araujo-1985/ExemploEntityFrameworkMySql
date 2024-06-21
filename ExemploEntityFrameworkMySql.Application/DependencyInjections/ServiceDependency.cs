using ExemploEntityFrameworkMySql.Application.Services;
using ExemploEntityFrameworkMySql.Domain.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEntityFrameworkMySql.Application.DependencyInjections
{
	public static class ServiceDependency
	{
		public static void AddClientDIServices(this IServiceCollection services)
		{
			services.AddTransient<IClienteService, ClienteService>();
		}
	}
}
