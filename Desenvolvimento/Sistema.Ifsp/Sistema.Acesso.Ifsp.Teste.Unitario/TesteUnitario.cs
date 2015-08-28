using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistema.Acesso.Ifsp.DAO;
using Sistema.Acesso.Ifsp.Model;
using System.Linq;

namespace Sistema.Acesso.Ifsp.Teste.Unitario
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var aluno = new Aluno()
            //{
            //    idPessoaFisica = 1,
            //    celular = "1",
            //    contato1 = "1",
            //    cpf = "1",
            //    email = "1",
            //    nascimento = new DateTime(1991, 01, 01),
            //    nome = "Tyler",
            //    Prontuario = new Prontuario()
            //    {
            //        prontuario = "1"
            //    },
            //    responsavel1 = "1",
            //    rg = "1",
            //    sexo = 'M'
            //};
            
            
            var assistentDAO = new AssistenteAlunoDAO();
            var assistente = assistentDAO.Find(3);
           
                        
            var porteiroDAo = new PorteiroDAO();
            var porteiro = porteiroDAo.Find(4);

            var alunoDAO = new AlunoDAO();
            var aluno = alunoDAO.Find(2);

            var solicitacao = new SolicitacaoSaida()
            {
                abertura = DateTime.Now,
                AssistenteAluno = assistente,
                Aluno = aluno,
                motivo = "Consulta médica",
                previsaoEncerramento = DateTime.Now.AddHours(1),
                status = "Aberto",
            };
            var soliciacaoDAO = new SolicitacaoSaidaDAO();
            soliciacaoDAO.Adicionar(solicitacao);
            soliciacaoDAO.Commit();
            //Assert.AreEqual(2, aluno.idPessoaFisica);
            //Assert.AreEqual("Tyler", aluno.nome);
            //alunoDAO.Adicionar(aluno);
            //alunoDAO.Commit();
        }
    }
}
