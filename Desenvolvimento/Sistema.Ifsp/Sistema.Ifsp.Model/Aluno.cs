using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*Data Annotations
[Table] dizemos ao Entity Framework o nome da tabela referente a essa entidade
[Required] seta essa propriedade como campo NOTNULL no banco de dados
[StringLenght] seta o tamanho limite do campo
*/
namespace Sistema.Ifsp.Model
{
    [Table("Aluno")]
    public class Aluno : PessoaFisica
    {
        /*propriedades*/
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
        /*propriedades de navegação
        através delas determinamos o relacionamento entre classes tais como associação
        que reflete como relacionamento entre entidades no banco de dados*/
        public virtual Prontuario Prontuario { get; set; }
        public virtual IEnumerable<SolicitacaoSaida> solicitacoes { get; set; }
    }
}
