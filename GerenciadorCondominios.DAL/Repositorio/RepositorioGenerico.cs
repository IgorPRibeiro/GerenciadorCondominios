using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorio
{
    //Responsavel pela implementacao dos métodos de IRepositorioGenerico.cs(em Interfaces)
    //Apertamos CRTL e . e geramos as interfaces
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        //Declarando contexto  
        private readonly Contexto _contexto;
        //Injecao de dependencia
        //passamos o valor da classe via construtor
        public RepositorioGenerico(Contexto contexto)
        {
            _contexto = contexto;
        }


        public async Task Atualizar(TEntity entity)
        {
            try
            {
                //chamamos nosso contexto
                //passomos o DbSet que sera executado Set<>
                //e executamos a função
                _contexto.Set<TEntity>().Update(entity);
                //Salvando as modificações
                //o salvamento é assincrono
                await _contexto.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(TEntity entity)
        {
            try
            {
                _contexto.Set<TEntity>().Remove(entity);                
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _contexto.Set<TEntity>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(string id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _contexto.Set<TEntity>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await _contexto.AddAsync(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> PegarPeloId(int id)
        {
            //retorna um registro do bando de dados
            try
            {
                return await _contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> PegarPeloId(string id)
        {
            try
            {
                return await _contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> PegarTodos()
        {
            //retorna o DbSet como uma lista
            try
            {
                return await _contexto.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
