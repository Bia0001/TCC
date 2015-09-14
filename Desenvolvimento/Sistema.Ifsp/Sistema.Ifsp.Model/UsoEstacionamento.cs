using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("UsoEstacionamento")]
    public class UsoEstacionamento
    {
        [Key]
        public int idUsoEstacionamento { get; set; }
        public DiaDaSemana diaDaSemana { get; set; }
        public DateTime entrada { get; set; }
        public DateTime saida { get; set; }
        public TipoVaga tipoVaga{ get; set; }
        public PessoaFisica pessoaFisica { get; set; }
        public string codAcessoEstacionamento { get; set; }
        public static int qtdVagas { get; set; }
    }
}