using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Repositorio
{
    //RepositorioGenerico<Usuario>, IUsuarioRepositorio => usamos "," para mostrar qual interface usar
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        //Toda vez que a classe base gera um contexto precisamos gerar um contrutor que faca a mesma coisa
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
