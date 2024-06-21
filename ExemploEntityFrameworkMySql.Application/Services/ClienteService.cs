using ExemploEntityFrameworkMySql.Domain.Contracts.Repositories;
using ExemploEntityFrameworkMySql.Domain.Contracts.Services;
using ExemploEntityFrameworkMySql.Domain.Entities;

namespace ExemploEntityFrameworkMySql.Application.Services
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _clienteRepository;

		public ClienteService(IClienteRepository clienteRepository)
		{
			_clienteRepository = clienteRepository;
		}

		public void Alterar(int id, Cliente cliente)
		{
			cliente.Id = id;
			_clienteRepository.AlterarParcial(cliente);
		}

		public void Excluir(int id) => _clienteRepository.Inativar(id);

		public void Incluir(Cliente cliente)
		{
			cliente.Status = true;
			_clienteRepository.Incluir(cliente);
		}

		public IEnumerable<Cliente> ListarTodos() => _clienteRepository.ListarTodos();

		public Cliente Pesquisar(int id) => _clienteRepository.Pesquisar(id);
	}
}
