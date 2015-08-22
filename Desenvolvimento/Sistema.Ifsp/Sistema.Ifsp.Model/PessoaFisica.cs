using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("PessoaFisica")]
    public class PessoaFisica
    {
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
