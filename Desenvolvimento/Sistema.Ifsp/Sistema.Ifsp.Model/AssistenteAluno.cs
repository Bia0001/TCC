using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("AssistenteAluno")]
    public class AssistenteAluno : Funcionario
    {
        public virtual ICollection<Solicitacao> solicitacao { get; set; }
    }
}
