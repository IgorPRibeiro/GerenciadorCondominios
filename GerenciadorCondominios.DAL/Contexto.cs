using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Mapeamento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL
{
    public class Contexto : IdentityDbContext<Usuario, Funcao, string>
    {
        //DbSet responsaveis pelas operações no banco de dados (Inserção de dados por exemplo)
        
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Funcao> Funcoes { get; set; }

        public DbSet<HistoricoRecursos> HistoricoRecursos { get; set; }

        public DbSet<Mes> Meses { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<ServicoPredio> ServicoPredios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        
        //Contrutor para a classe
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
        
        
        //Sobrescrever a funcao de criação dos dados
        //Para que seja aplicada todas as configuracoes feitas nos arquivos de mapeamento
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AluguelMap());
            builder.ApplyConfiguration(new ApartamentoMap());
            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new HistoricosRecursosMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new ServicoMap());
            builder.ApplyConfiguration(new ServicoPrediosMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VeiculoMap());
        }
    }
}
