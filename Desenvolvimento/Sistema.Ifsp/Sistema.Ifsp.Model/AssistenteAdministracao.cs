using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("AssistenteAdministracao")]
    public class AssistenteAdministracao : Funcionario
    {
        public virtual ICollection<PermanenciaVeiculo> permanenciasVeiculos { get; set; }
    }
}
