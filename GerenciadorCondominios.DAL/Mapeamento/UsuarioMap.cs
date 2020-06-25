using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.CPF).IsRequired().HasMaxLength(30);
            //HasIndex(INDICE).Ou seja ,nesse caso , o CPF é unico
            builder.HasIndex(u => u.CPF).IsUnique();
            builder.Property(u => u.Foto).IsRequired();
            builder.Property(u => u.PrimeiroAcesso).IsRequired();
            builder.Property(u => u.Status).IsRequired();
            //RELACIONAMENTOS
            builder.HasMany(u => u.ProprietarioApartamento).WithOne(u => u.Proprietario);
            builder.HasMany(u => u.MoradoresApartamento).WithOne(u => u.Morador);
            builder.HasMany(u => u.Veiculos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Pagamentos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);

            builder.ToTable("Usuario");
        }
    }
}
