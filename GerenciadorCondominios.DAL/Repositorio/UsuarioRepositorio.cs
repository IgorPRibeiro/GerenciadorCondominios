using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorio
{
    //RepositorioGenerico<Usuario>, IUsuarioRepositorio => usamos "," para mostrar qual interface usar
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto _contexto;
        //atributo para gerenciar as operacoes dos usuarios
        private readonly UserManager<Usuario> _gerenciadorUsuario;
        //atributo para gerenciar o Login
        private readonly SignInManager<Usuario> _gerenciadorLogin;


        //Toda vez que a classe base gera um contexto precisamos gerar um contrutor que faca a mesma coisa
        public UsuarioRepositorio(Contexto contexto, UserManager<Usuario> gerencadorUsuario, SignInManager<Usuario> gerenciarLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuario = gerencadorUsuario;
            _gerenciadorLogin = gerenciarLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await _gerenciadorUsuario.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao)
        {
            try
            {
                await _gerenciadorUsuario.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LogarUsuario(Usuario usuario, bool lembrar)
        {
            try
            {
                await _gerenciadorLogin.SignInAsync(usuario, lembrar);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int VerificarSeExisteRegistro()
        {
            try
            {
                return _contexto.Usuarios.Count();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
