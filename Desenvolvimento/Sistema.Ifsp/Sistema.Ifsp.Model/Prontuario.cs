using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Prontuario")]
    public class Prontuario
    {
        [Key]
        public int idProntuario { get; set; }
        [Required]
        [StringLength(7)]
        public string prontuario { get; set; }
    }
}