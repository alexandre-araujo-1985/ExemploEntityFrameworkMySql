using ExemploEntityFrameworkMySql.Domain.Entities;

namespace ExemploEntityFrameworkMySql.Domain.Contracts.Repositories
{
	public interface IClienteRepository : IRepositoryBase<Cliente>
	{
		void AlterarParcial(Cliente cliente);
		void Inativar(int id);
	}
}
