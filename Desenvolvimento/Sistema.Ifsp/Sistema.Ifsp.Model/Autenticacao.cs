using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Autenticacao")]
    public class Autenticacao
    {
        [Key]
        public int idAutenticacao { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string senha { get; set; }
        [Required]
        public string nivelAcesso { get; set; }
    }
}
