using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Terceirizado")]
    public class Terceirizado : PessoaFisica
    {
        public string area { get; set; }
        public string empresa { get; set; }

        public virtual Autenticacao autenticacao { get; set; }
    }
}
