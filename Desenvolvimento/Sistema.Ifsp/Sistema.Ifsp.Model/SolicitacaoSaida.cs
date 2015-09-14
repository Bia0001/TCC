using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("SolicitacaoSaida")]
    public class SolicitacaoSaida : Solicitacao
    {
        public DateTime encerramento { get; set; }
        public virtual ICollection<Porteiro> porteiro { get; set; }
    }
}
