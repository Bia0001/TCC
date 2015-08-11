using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class Vigilante : PessoaFisica
    {
        /*propriedade de navegação*/
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
