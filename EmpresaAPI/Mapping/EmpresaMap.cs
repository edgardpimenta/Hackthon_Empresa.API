using EmpresaAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpresaAPI.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            //mapeamento do nome da tabela
            builder.ToTable("EMPRESA");
            //mapeamento do campo chave primária
            builder.HasKey(p => p.Id);
            //mapeamento dos campos da tabela
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME")
                                        .HasMaxLength(100)
                                        .IsRequired();

            builder.Property(p => p.Telefone).HasColumnName("TELEFONE")
                                        .HasMaxLength(15)
                                        .IsRequired();


            builder.Property(p => p.CNPJ)

            .HasColumnName("CNPJ").IsRequired();

            builder.Property(p => p.RazaoSocial)

            .HasColumnName("RazaoSocial").IsRequired();

            builder.Property(p => p.Endereco)

            .HasColumnName("Endereco").IsRequired();
        }
    }
}
