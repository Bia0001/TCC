using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*Dada Annotations
[Key] seta propriedade como campo de chave primaria no banco de dados
*/
namespace Sistema.Ifsp.Model
{
    [Table("PessoaFisica")]
    public class PessoaFisica
    {
        /*propriedade*/
        [Key]
        public int idPessoaFisica { get; set; }
        [Required]
        [StringLength(100)]
        public string nome { get; set; }
        [Required]
        [StringLength(11)]
        public string cpf { get; set; }
        [Required]
        [StringLength(9)]
        public string rg { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        [StringLength(11)]
        public string celular { get; set; }
        [StringLength(10)]
        public string telefone { get; set; }
        [Required]
        public char sexo { get; set; }
        [Required]
        public DateTime nascimento { get; set; }
    }
}
