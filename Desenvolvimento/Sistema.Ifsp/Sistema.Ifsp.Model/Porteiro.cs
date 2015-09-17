using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{

    [Table("Porteiro")]
    public class Porteiro : Terceirizado
    {
        public virtual ICollection<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
