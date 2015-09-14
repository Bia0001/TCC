using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("AdministradorSitema")]
    public class AdministradorSistema
    {
        [Key]
        public int idAdministradorSistema { get; set; }
        public Prontuario prontuario { get; set; }
    }
}
