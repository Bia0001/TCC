using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Ifsp.Model
{
    [Table("Aluno")]
    public class Aluno : PessoaFisica
    {
        public string responsavel1 { get; set; }
        public string responsavel2 { get; set; }
        public string contato1 { get; set; }
        public string contato2 { get; set; }
        public Prontuario prontuario { get; set; }
    }
}
