using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Solicitacao")]
    public class Solicitacao
    {
        [Key]
        public int idSolicitacao { get; set; }
        public DateTime aberura { get; set; }
        public string motivo { get; set; }
        public StatusSolicitacao status { get; set; }
        public virtual ICollection<Aluno> aluno { get; set; }
        public virtual ICollection<AssistenteAluno> assistenteAluno { get; set; }
    }
}
