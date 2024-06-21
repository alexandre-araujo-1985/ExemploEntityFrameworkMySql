using Microsoft.EntityFrameworkCore;
using ExemploEntityFrameworkMySql.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploEntityFrameworkMySql.Infra.Configurations
{
	public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
	{
		public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("tb_clientes");

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
			builder.Property(c => c.DataCadastro).HasColumnName("data_cadastro").HasColumnType("datetime");
			builder.Property(c => c.DataAlteracao).HasColumnName("data_alteracao").HasColumnType("datetime");
			builder.Property(c => c.Status).HasColumnName("status");
		}
	}
}
