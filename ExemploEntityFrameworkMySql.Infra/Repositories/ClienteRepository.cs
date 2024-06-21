using ExemploEntityFrameworkMySql.Domain.Entities;
using ExemploEntityFrameworkMySql.Domain.Contracts.Repositories;
using ExemploEntityFrameworkMySql.Infra.Contexts;

namespace ExemploEntityFrameworkMySql.Infra.Repositories
{
	public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
	{
		public ClienteRepository(ExemploEntityFrameworkMySqlContext context) : base(context)
		{
		}
	}
}
