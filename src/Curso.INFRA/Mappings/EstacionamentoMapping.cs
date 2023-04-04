using Curso.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Infra.Mappings;

public class EstacionamentoMapping : IEntityTypeConfiguration<EstacionamentoModel>
{
    public void Configure(EntityTypeBuilder<EstacionamentoModel> builder)
    {
        //public Guid Id { get; set; }
        builder.HasKey(lbda => lbda.Id);

        //public required string Nome { get; set; }
        builder.Property(lbda => lbda.Nome)
            .HasColumnType("varchar(80)")
            .IsRequired();

        //public required int Capacidade { get; set; }
        builder.Property(lbda => lbda.Capacidade)
           .HasColumnType("varchar(80)")
           .IsRequired();

        //public required string Estado { get; set; }
        builder.Property(lbda => lbda.Estado)
           .HasColumnType("varchar(80)")
           .IsRequired();

        //public required string Cidade { get; set; }
        builder.Property(lbda => lbda.Cidade)
          .HasColumnType("varchar(80)")
          .IsRequired();

        //public required string Bairro { get; set; }
        builder.Property(lbda => lbda.Bairro)
         .HasColumnType("varchar(80)")
         .IsRequired();

        //public required string Lougradouro { get; set; }
        builder.Property(lbda => lbda.Lougradouro)
         .HasColumnType("varchar(100)")
         .IsRequired();

        //public required string Numero { get; set; }
        builder.Property(lbda => lbda.Numero)
        .HasColumnType("varchar(5)")
        .IsRequired();

        //public string? Complemento { get; set; }
        builder.Property(lbda => lbda.Complemento)
        .HasColumnType("varchar(7)")
        .IsRequired(false);

    }
}
