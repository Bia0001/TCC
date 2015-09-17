using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Terceirizado")]
    public class Terceirizado : PessoaFisica
    {
        [Key]
        public string area { get; set; }
        public string empresa { get; set; }
    }
}
