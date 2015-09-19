using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Aluno")]
    public class Aluno : PessoaFisica
    {
        [Required]
        public string responsavel1 { get; set; }
        public string responsavel2 { get; set; }
        [Required]
        public string contato1 { get; set; }
        public string contato2 { get; set; }
        [Required]
        public virtual Prontuario prontuario { get; set; }
        public virtual IEnumerable<Solicitacao> solicitacoes { get; set; }
    }
}
