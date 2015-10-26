using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Dia")]
    public class Dia
    {
        [Key]
        public int idDia { set; get; }
        public string periodo { set; get; }
        public virtual PessoaFisica pessoaFisica { get; set; }
    }
}