﻿using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.EFData.Map
{
    public class RegistroVendaMap : IEntityTypeConfiguration<RegistroVendas>
    {
        public void Configure(EntityTypeBuilder<RegistroVendas> builder)
        {
            builder.ToTable("RegistrosVenda");
            builder.HasKey(venda => venda.VendaId);

            builder.Property(venda => venda.VendaId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(venda => venda.Codigo);
            builder.Property(venda => venda.NomeProduto);
            builder.Property(venda => venda.Vendedor);
            builder.Property(venda => venda.PrecoUnitario);
            builder.Property(venda => venda.Quantidade);

            builder.Ignore(usuario => usuario.ChavePrimaria);
            builder.Ignore(usuario => usuario.ValidationErrors);
        }
    }
}