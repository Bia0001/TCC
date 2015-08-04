
namespace Sistema.Acesso.Entidades
{
    public class Endereco
    {
        /*propriedade*/
        public int idEndereco { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }

        /*propriedade de navegação*/
        public virtual PessoaFisica pessoaFisica { get; set; }
    }
}
