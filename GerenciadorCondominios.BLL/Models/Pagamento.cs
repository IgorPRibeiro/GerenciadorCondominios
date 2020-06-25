using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }

        //FOREIGN KEY Usuario
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        //FOREIGN KEY Aluguel
        public string AluguelId { get; set; }
        public virtual Aluguel Aluguel { get; set; }

        //PODE SER NULO
        public DateTime? DataPagamento { get; set; }

        public StatusPagamento Status { get; set; }

    }
    //enum fornece metodos para comparar instancias da classe
    //https://www.w3schools.com/cs/cs_enums.asp
    public enum StatusPagamento { 
        Pago, Pendente, Atrasado    
    }
}

