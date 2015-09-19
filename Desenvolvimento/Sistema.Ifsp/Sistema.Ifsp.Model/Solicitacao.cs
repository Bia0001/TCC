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
        [Required]
        public DateTime abertura { get; set; }
        [Required]
        public string motivo { get; set; }
        [Required]
        public virtual Aluno aluno { get; set; }
        [Required]
        public virtual AssistenteAluno assistenteAluno { get; set; }
    }
}
