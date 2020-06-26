using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamento
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.ApartamentoId);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Andar).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            //builder.Property(a => a.ProprietarioId).IsRequired(false);
            //builder.Property(a => a.Morador).IsRequired(false);

            //RELACIONAMENTO
            builder.HasOne(a => a.Proprietario).WithMany(a => a.ProprietarioApartamento).HasForeignKey(a => a.ProprietarioId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Morador).WithMany(a => a.MoradoresApartamento).HasForeignKey(a => a.MoradorId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Apartamento");
        }
    }
}
