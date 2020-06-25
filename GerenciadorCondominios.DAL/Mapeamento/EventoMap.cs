using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamento
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.EventoId);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Data).IsRequired();
            builder.Property(e => e.UsuarioId).IsRequired();

            //RELACIONAMENTOS
            builder.HasOne(e => e.Usuario).WithMany(e => e.Eventos).HasForeignKey(e => e.UsuarioId);

            builder.ToTable("Eventos");
        }
    }
}
