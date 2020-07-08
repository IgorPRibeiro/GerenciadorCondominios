using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.DAL.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL
{
    public static class ConfiguracaoRepositorioExtencion
    {
        public static void ConfigurarRepositorio(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
 