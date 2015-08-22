using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("AssistenteAluno")]
    public class AssistenteAluno : PessoaFisica
    {
        /*propriedades de navegação*/
        public virtual Prontuario Prontuario { get; set; }
        public virtual IEnumerable<SolicitacaoSaida> Solicitacoes { get; set; }
    }
}