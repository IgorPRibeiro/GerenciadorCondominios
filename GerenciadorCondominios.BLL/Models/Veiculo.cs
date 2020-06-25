using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        //{0} => NOME DO CAMPO
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(20,ErrorMessage ="Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20,ErrorMessage ="Use menos caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20,ErrorMessage ="Use menos caracteres")]
        public string Cor { get; set; }

        public string Placa { get; set; }

        //FOREGEIN KEY
        public string UsuarioID { get; set; }


        public Usuario Usuario { get; set; }


    }
}
