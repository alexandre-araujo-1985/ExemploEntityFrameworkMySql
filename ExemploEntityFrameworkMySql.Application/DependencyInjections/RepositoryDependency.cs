using ExemploEntityFrameworkMySql.Domain.Contracts.Repositories;
using ExemploEntityFrameworkMySql.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEntityFrameworkMySql.Application.DependencyInjections
{
	public static class RepositoryDependency
	{
		public static void AddClientDIRepositories(this IServiceCollection services)
		{
			services.AddTransient<IClienteRepository, ClienteRepository>();
		}
	}
}
