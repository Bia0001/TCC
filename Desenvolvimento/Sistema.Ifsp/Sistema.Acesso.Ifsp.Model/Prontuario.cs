using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Acesso.Ifsp.Model
{
    [Table("Prontuario")]
    public class Prontuario
    {
        /*propriedade*/
        [Key]
        public int idProntuario { get; set; }
        /*propriedade de navegação*/
        [Required]
        [StringLength(7)]
        public string prontuario { get; set; }
    }
}