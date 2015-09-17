using Sistema.Ifsp.DAO;
using Sistema.Ifsp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Ifsp.Control
{
    public class AlunoControl : PessoaFisicaControl
    {
        public override bool cadastrar(string nome, string rg, string celular, string telefone, char sexo, DateTime nascimento, 
            string prontuario, string contato1, string contato2, string responsavel1, string responsavel2)
        {
            try
            {
                var a = new Aluno()
                {
                    celular = celular,
                    contato1 = contato1,
                    contato2 = contato2,
                    nascimento = nascimento,
                    nome = nome,
                    prontuario = new Prontuario
                    {
                        prontuario = prontuario
                    },
                    responsavel1 = responsavel1,
                    responsavel2 = responsavel2
                };
                var aDAO = new AlunoDAO();
                if (aDAO.adicionar(a))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
