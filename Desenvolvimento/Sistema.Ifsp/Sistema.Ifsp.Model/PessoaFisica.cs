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
        public string nome { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        public char sexo { get; set; }
        public DateTime nascimento { get; set; }
    }
}
