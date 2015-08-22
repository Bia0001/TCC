using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("AssistenteAluno")]
    public class AssistenteAluno : PessoaFisica
    {
        //[ForeignKey("fkProntuario")]
        public virtual Prontuario Prontuario { get; set; }
        //[ForeignKey("fkSolicitacaoSaida")]
        public virtual IEnumerable<SolicitacaoSaida> Solicitacoes { get; set; }
    }
}