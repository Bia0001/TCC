using System.Collections.Generic;

namespace Sistema.Acesso.Entidades
{
    public class Vigilante : PessoaFisica
    {
        /*propriedades*/
        public int idVigilante { get; set; }

        /*propriedade de navegação*/
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
