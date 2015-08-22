using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("SolicitacaoSaida")]
    public class SolicitacaoSaida
    {
        /*propriedade*/
        [Key]
        public int idSolicitacaoSaida { get; set; }
        [Required]
        public DateTime abertura { get; set; }
        [Required]
        public DateTime previsaoEncerramento { get; set; }
        public DateTime? encerramento { get; set; }
        [Required]
        [StringLength(300)]
        public string motivo { get; set; }
        [Required]
        [StringLength(10)]
        public string status { get; set; }
        /*propriedades de navegação*/
        public virtual Aluno Aluno { get; set; }        
        public virtual AssistenteAluno AssistenteAluno { get; set; }
        public virtual Vigilante Vigilante { get; set; }
    }
}