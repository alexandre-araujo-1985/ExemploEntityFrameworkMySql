using Microsoft.EntityFrameworkCore;
using ExemploEntityFrameworkMySql.Domain.Entities;
using ExemploEntityFrameworkMySql.Infra.Configurations;

namespace ExemploEntityFrameworkMySql.Infra.Contexts
{
	public class ExemploEntityFrameworkMySqlContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ClienteConfiguration());
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=exemplo_entity_framawork;user=root;password=123456");
		}
	}
}
