using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    //Essa classe herda de IdentityRole(é um pacote) e a chave estrangeira é uma string
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
