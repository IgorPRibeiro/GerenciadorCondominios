using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamento
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            //As chaves primaria de Função e Usuario ja vem configurada
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);
            //NormalizedName(propriedade).Com ele comparamos o nome da função em caso de adição e exclusão de usuario
            builder.HasData(
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Morador",
                        NormalizedName = "MORADOR",
                        Descricao = "Morador do Prédio"
                    },
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Sindico",
                        NormalizedName = "SINDICO",
                        Descricao = "Sindico do Prédio"
                    },
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Administrador",
                        NormalizedName = "ADMINISTRADOR",
                        Descricao = "Morador do Prédio"
                    }
                );
            builder.ToTable("Funcoes");
        }
    }
}
