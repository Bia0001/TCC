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
        public DateTime aberura { get; set; }
        [Required]
        public string motivo { get; set; }
        [Required]
        public Aluno aluno { get; set; }
        [Required]
        public AssistenteAluno assistenteAluno { get; set; }
    }
}
