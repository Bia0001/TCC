using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key]
        public int idVaga { set; get; }
        [Required]
        public string codigoPlaca { set; get; }
        public bool isDocente { set; get; }
        public virtual Dia domingo { set; get; }
        public virtual Dia segunda_feira { set; get; }
        public virtual Dia terca_feira { set; get; }
        public virtual Dia quarta_feira { set; get; }
        public virtual Dia quinta_feira { set; get; }
        public virtual Dia sexta_feira { set; get; }
        public virtual Dia sabado { set; get; }
        public virtual PessoaFisica pessoaFisica { get; set; }
    }
}
