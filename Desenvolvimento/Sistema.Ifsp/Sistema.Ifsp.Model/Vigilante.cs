﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Vigilante")]
    public class Vigilante : PessoaFisica
    {
        /*propriedade de navegação*/
        public virtual IEnumerable<SolicitacaoSaida> Solicitacoes { get; set; }
    }
}