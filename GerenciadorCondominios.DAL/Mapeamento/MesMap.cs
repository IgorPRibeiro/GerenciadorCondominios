using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamento
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            //Configurando a chave primaria
            builder.HasKey(m => m.MesID);
            builder.Property(m => m.MesID).ValueGeneratedNever();

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nome).IsUnique();

            //RELACIONAMENTO
            builder.HasMany(m => m.Alugueis).WithOne(m => m.Mes);
            builder.HasMany(m => m.HistoricoRecursos).WithOne(m => m.Mes);

            builder.HasData(
                new Mes
                {
                    MesID = 1,
                    Nome = "Janeiro"
                },

                new Mes
                {
                    MesID = 2,
                    Nome = "Fevereiro"
                },
                new Mes
                {
                    MesID = 3,
                    Nome = "Março"
                },
                new Mes
                {
                    MesID = 4,
                    Nome = "Abril"
                },
                new Mes
                {
                    MesID = 5,
                    Nome = "Maio"
                },
                new Mes
                {
                    MesID = 6,
                    Nome = "Junho"
                },
                new Mes
                {
                    MesID = 7,
                    Nome = "Julho"
                },
                new Mes
                {
                    MesID = 8,
                    Nome = "Agosto"
                },
                new Mes
                {
                    MesID = 9,
                    Nome = "Setembro"
                },
                new Mes
                {
                    MesID = 10,
                    Nome = "Outubro"
                },
                new Mes
                {
                    MesID = 11,
                    Nome = "Novembro"
                },
                new Mes
                {
                    MesID = 12,
                    Nome = "Dezembro"
                }
                
                ) ;
            builder.ToTable("Meses");
        }
    }
}
