using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Acesso.Ifsp.Model
{
    [Table("Porteiro")]
    public class Porteiro : PessoaFisica
    {
        public virtual IEnumerable<SolicitacaoSaida> Solicitacoes { get; set; }
    }
}