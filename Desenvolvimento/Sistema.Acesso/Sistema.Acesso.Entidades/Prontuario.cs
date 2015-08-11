using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class Prontuario
    {
        /*propriedades*/
        [Key]
        public int idProntuario { get; set; }
        public string prontuario { get; set; }
    }
}
