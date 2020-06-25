using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    //Herda de IdentityUser e a chave primaria é uma string
    public class Usuario : IdentityUser<string>
    {
        //atributos referentes ao usuario
        public string CPF { get; set; }

        public string Foto { get; set; }

        public bool PrimeiroAcesso { get; set; }

        public StatusConta Status { get; set; }

        //Usamos o ICollection para relacionamentos 1..N (ICollection fica do lado N) 
        //e para termos alguns métodos adicionais como, por exemplo, adição, exclusão, cópia e contagem de itens.
        public virtual ICollection<Apartamento> MoradoresApartamento { get; set; }
        public virtual ICollection<Apartamento> ProprietarioApartamento { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }

    }
    public enum StatusConta
    {
        Analisando, Aprovado, Reprovado
    }
}
