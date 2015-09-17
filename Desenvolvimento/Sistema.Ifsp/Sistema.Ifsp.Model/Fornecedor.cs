using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public int idFornecedor { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public DateTime entrada { get; set; }
        public DateTime saida { get; set; }
        public string empresa { get; set; }
        public string motivo { get; set; }
    }
}
