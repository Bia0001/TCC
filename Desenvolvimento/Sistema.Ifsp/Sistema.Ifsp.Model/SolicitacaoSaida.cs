using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("SolicitacaoSaida")]
    public class SolicitacaoSaida : Solicitacao
    {
        public bool saidaSupervisionada { get; set; }
        public StatusSolicitacao status { get; set; }
        public DateTime? encerramento { get; set; }
        public Porteiro porteiro { get; set; }
    }
}
