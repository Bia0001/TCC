using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Aluno")]
    public class Aluno : PessoaFisica
    {
        [Required]
        [StringLength(11)]
        public string contato1 { get; set; }
        [StringLength(11)]
        public string contato2 { get; set; }
        [Required]
        [StringLength(100)]
        public string responsavel1 { get; set; }
        [StringLength(100)]
        public string responsavel2 { get; set; }
        public virtual Prontuario Prontuario { get; set; }
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
