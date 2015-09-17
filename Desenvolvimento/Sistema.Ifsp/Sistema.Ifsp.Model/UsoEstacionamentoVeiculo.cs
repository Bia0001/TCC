using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("UsoEstacionamentoVeiculo")]
    public abstract class UsoEstacionamentoVeiculo
    {
        [Key]
        public int idUsoEstacionamento { get; set; }
        [Required]
        public string diaDaSemana { get; set; }
        [Required]
        public DateTime entrada { get; set; }
        [Required]
        public DateTime saida { get; set; }
        [Required]
        public TipoVaga tipoVaga{ get; set; }
        [Required]
        public PessoaFisica pessoaFisica { get; set; }
        public string codAcessoEstacionamento { get; set; }
        public static int qtdVagas { get; set; }
    }
}