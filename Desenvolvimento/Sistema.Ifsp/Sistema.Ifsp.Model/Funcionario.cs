using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Funcionario")]
    public class Funcionario : PessoaFisica
    {
        public Area area { get; set; }
    }
}
