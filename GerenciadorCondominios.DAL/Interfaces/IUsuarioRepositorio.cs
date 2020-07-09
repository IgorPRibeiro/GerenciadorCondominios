using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        int VerificarSeExisteRegistro();

        //Task = assincrono
        Task LogarUsuario(Usuario usuario, bool lembrar);
        //Esse metodo retorna o IdentityResult
        //IdentityResult = sera o status da operacao
        //se der certo ira retorna um sucess e se der um erro retornara um fail,e assim, vai poder percorrer os erros que foram retornados
        Task DeslogarUsuario();
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);

        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);

        Task<Usuario> PegarUsuarioPeloEmail(string email);

        
    }
}
