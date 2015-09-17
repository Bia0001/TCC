using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Funcionario")]
    public class Funcionario : PessoaFisica
    {
        public string area { get; set; }
        public Prontuario prontuario { get; set; }

    }
}
