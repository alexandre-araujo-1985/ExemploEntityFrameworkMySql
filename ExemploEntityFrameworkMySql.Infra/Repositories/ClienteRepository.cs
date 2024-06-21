using ExemploEntityFrameworkMySql.Domain.Entities;
using ExemploEntityFrameworkMySql.Domain.Contracts.Repositories;
using ExemploEntityFrameworkMySql.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ExemploEntityFrameworkMySql.Infra.Repositories
{
	public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
	{
		public ClienteRepository(ExemploEntityFrameworkMySqlContext context) : base(context)
		{
		}

		public void AlterarParcial(Cliente cliente)
		{
			_context.Clientes
				.Where(c => c.Id == cliente.Id)
				.ExecuteUpdate(u => u
					.SetProperty(c => c.Nome, cliente.Nome)
					.SetProperty(c => c.DataAlteracao, DateTime.Now));
		}

		public void Inativar(int id)
		{
			_context.Clientes
				.Where(c => c.Id == id)
				.ExecuteUpdate(u => u
					.SetProperty(c => c.Status, false)
					.SetProperty(c => c.DataAlteracao, DateTime.Now));
		}
	}
}
