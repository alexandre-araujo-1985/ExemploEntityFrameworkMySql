﻿using ExemploEntityFrameworkMySql.Domain.Contracts.Repositories;
using ExemploEntityFrameworkMySql.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ExemploEntityFrameworkMySql.Infra.Repositories
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected ExemploEntityFrameworkMySqlContext _context;

		public RepositoryBase(ExemploEntityFrameworkMySqlContext context)
		{
			_context = context;
		}

		public void Alterar(T obj)
		{
			_context.Entry(obj).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public void Excluir(int id)
		{
			var obj = Pesquisar(id);
			MontarInstancia().Remove(obj);
			_context.SaveChanges();
		}

		public void Incluir(T obj)
		{
			MontarInstancia().Add(obj);
			_context.SaveChanges();
		}

		public IEnumerable<T> ListarTodos()
		{
			return [.. MontarInstancia()];
		}

		public T Pesquisar(int id)
		{
			return MontarInstancia().Find(id)!;
		}

		private DbSet<T> MontarInstancia() => _context.Set<T>();
	}
}
