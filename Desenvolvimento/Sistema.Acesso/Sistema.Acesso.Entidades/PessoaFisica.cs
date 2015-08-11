using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class PessoaFisica
    {
        /*propriedades*/
        [Key]
        public int idPessoaFisica { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        public char sexo { get; set; }
        public DateTime nascimento { get; set; }

        /*propriedades de navegação*/
        public virtual IEnumerable<Endereco> enderecos { get; set; }
    }
}