using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class Endereco
    {
        /*propriedade*/
        [Key]
        public int idEndereco { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public PessoaFisica pessoaFisica { get; set; }
    }
}
