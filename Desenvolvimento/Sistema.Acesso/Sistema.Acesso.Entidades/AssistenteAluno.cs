using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class AssistenteAluno : PessoaFisica
    {
        /*propriedades*/
        public Prontuario prontuario { get; set; }

        /*propriedade de navegação*/
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
