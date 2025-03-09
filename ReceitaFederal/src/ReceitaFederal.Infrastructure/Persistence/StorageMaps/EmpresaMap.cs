using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceitaFederal.Domain.Entities;

namespace ReceitaFederal.Infrastructure.Persistence.StorageMaps
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(e => e.CnpjBasico);

            builder.Property(e => e.CnpjBasico)
                .HasColumnName("cnpj_basico")
                .HasMaxLength(8)
                .IsRequired();
            
            builder.Property(e => e.RazaoSocial)
                .HasColumnName("razao_social")
                .HasMaxLength(255);
            
            builder.Property(e => e.NaturezaJuridica)
                .HasColumnName("natureza_juridica")
                .HasMaxLength(4);
            
            builder.Property(e => e.QualificacaoResponsavel)
                .HasColumnName("qualificacao_responsavel")
                .HasMaxLength(2);
            
            builder.Property(e => e.CapitalSocial)
                .HasColumnName("capital_social")
                .HasColumnType("decimal(18, 2)");
            
            builder.Property(e => e.PorteEmpresa)
                .HasColumnName("porte_empresa")
                .HasMaxLength(1);
            
            builder.Property(e => e.EnteFederativoResponsavel)
                .HasColumnName("ente_federativo_responsavel")
                .HasMaxLength(255);
        }
    }
}