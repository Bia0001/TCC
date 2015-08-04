using System.Collections.Generic;

namespace Sistema.Acesso.Entidades
{
    public class AssistenteAluno : PessoaFisica
    {
        /*propriedades*/
        public int idAssistenteAluno { get; set; }
        public Prontuario prontuario { get; set; }

        /*propriedade de navegação*/
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
