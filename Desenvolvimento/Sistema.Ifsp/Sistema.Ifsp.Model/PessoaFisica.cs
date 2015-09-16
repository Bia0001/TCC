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
        public string nome { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        [Required]
        public char sexo { get; set; }
        [Required]
        public DateTime nascimento { get; set; }
        [Required]
        public string rg { get; set; }
    }
}
