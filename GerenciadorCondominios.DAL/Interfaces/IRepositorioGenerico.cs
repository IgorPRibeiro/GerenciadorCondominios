using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    //O I no começo do nome da classe se refere que ela é uma interface
    //Quando não sabemos qual classe ela possui usaramos o <TEntity>
    //Essa classe sera definida em tempo de compilacao(por isso conseguimos utilazamos com varias outras classes)
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        //PEGAR TODOS
        //nos retorna uma lista do banco de dados de uma determinada tabela
        //Não sabemos o tipo entao denovo usarremos o TEntiy
        Task<IEnumerable<TEntity>> PegarTodos();

        //PEGAR PELO ID
        //Vai retornar um registro pelo seu id(uma classe)
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);

        //INSERIR
        //Como não temos um retorno nessa classe não precisa usar o <TEntity>
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);

        //Na classe excluir teremos 3 variantes
        Task Excluir(TEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);


    }
}
