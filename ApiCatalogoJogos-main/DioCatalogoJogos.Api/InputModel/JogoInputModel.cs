using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DioCatalogoJogos.Api.InputModel
{
    public class JogoInputModel
    {

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = " O nome do jogo deve conter 3 e 100 Caracteres")]

        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = " O nome da produtora deve conter entre 3 e 100 Caracteres")]
        public string Produtora { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = " O o preço deve ser fr no minimo 1 real e no maximo 1000 reais")]
        public double Preco { get; set; }

    }
}



