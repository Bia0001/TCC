using System;
using Sistema.Ifsp.BO;
using Sistema.Ifsp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Sistema.Ifsp.Repositorio;

namespace Sistema.Ifsp.Test.Unitario
{
    [TestClass]
    public class Test
    {
        //[TestMethod]
        //public void AdicionandoAlunoVigilanteAssistente()
        //{
        //    var alunoBo = new AlunoBO();
        //    var aluno = new Aluno()
        //    {
        //        celular = "2",
        //        cpf = "2",
        //        contato1 = "2",
        //        nascimento = new DateTime(1992, 02, 02),
        //        nome = "Lucas",
        //        Prontuario = new Prontuario()
        //        {
        //            prontuario = "1",
        //        },
        //        responsavel1 = "2",
        //        rg = "2",
        //        sexo = 'M'
        //    };
        //    alunoBo.Adicionar(aluno);
        //}

        //[TestMethod]
        //public void BuscarAluno()
        //{
        //    var alunoBo = new AlunoBO();
        //    var aluno = alunoBo.Pesquisar(1);
        //    Assert.AreEqual(1, aluno.idPessoaFisica);
        //    Assert.AreEqual("1", aluno.Prontuario.prontuario);
        //}

        //[TestMethod]
        //public void AdicionarAssistente()
        //{
            //var assistente = new AssistenteAluno()
            //{
            //    cpf = "assstente",
            //    nascimento = new DateTime(1992, 04, 04),
            //    nome = "Pedrinho",
            //    Prontuario = new Prontuario()
            //    {
            //        prontuario = "2",
            //    },
            //    rg = "1234",
            //    sexo = 'M'
            //};
            //var assistenteBo = new AssistenteAlunoBO();
            //assistenteBo.Adicionar(assistente);
            //assistenteBo.Delete(4);
        //}

        [TestMethod]
        public void AdicionarSolicitacao()
        {
            var dt = DateTime.Now;
            var contexto = new BancoContexto();
            List<SolicitacaoSaida> solicitacoes = contexto.SolicitacoesSaida.Where(s => s.abertura.Day == DateTime.Now.Day &&
            s.abertura.Month == dt.Month && s.abertura.Year == dt.Year).ToList();
            //var solBO = new SolicitacaoSaidaBO();
            //var sol = solBO.PesquisarSolicitacoesHoje();
            Assert.AreEqual(solicitacoes[0].idSolicitacaoSaida, 6);
            Assert.AreEqual(solicitacoes.Count(), 4);





            //var vigilante = new Vigilante()
            //{
            //    nascimento = new DateTime(1990, 04, 04),
            //    nome = "Samule Mucão",
            //    rg = "4",
            //    sexo = 'M',
            //    cpf = "4"
            //};
            //var vigilanteBo = new VigilanteBO();
            //var vigilante = vigilanteBo.Pesquisar(3);
            //var alunoBo = new AlunoBO();
            //var aluno = alunoBo.PesquisarProntuario("1");
            //Assert.AreEqual(1, aluno.idPessoaFisica);
            //var assistenteBo = new AssistenteAlunoBO();
            //var assistente = assistenteBo.PesquisarProntuario("2");
            //Assert.AreEqual(2, assistente.idPessoaFisica);


            //var solBO = new SolicitacaoSaidaBO();
            //var solicitacao = new SolicitacaoSaida()
            //{
            //    abertura = DateTime.Now,
            //    Aluno = aluno,
            //    AssistenteAluno = assistente,
            //    //Vigilante = vigilante,
            //    previsaoEncerramento = DateTime.Now.AddMinutes(45),
            //    status = "Expirado",
            //    motivo = "Dor de barriga"
            //};
            //solBO.Adicionar(solicitacao);
        }
    }
}
