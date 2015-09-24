using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Visitante")]
    public class Visitante
    {
        [Key]
        public int idVisitante { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public DateTime entrada { get; set; }
        public DateTime? saida { get; set; }
        public string empresa { get; set; }
        public string motivo { get; set; }
    }
}
