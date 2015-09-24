using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistema.Ifsp.Model;
using Sistema.Ifsp.DAO;
using System.Linq;

namespace Sistema.Ifsp.Test.Unitario
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = new Aluno()
            {
                celular = "1999748362",
                contato1 = "1993748392",
                contato2 = "1992480483",
                nascimento = new DateTime(1992, 03, 04),
                nome = "Willian Costa",
                prontuario = new Prontuario()
                {
                    prontuario = "1320011"
                },
                responsavel1 = "Hugo Silva",
                responsavel2 = "Beatriz Souza",
                rg = "507382748",
                sexo = 'M',
                telefone = "19966338844"
            };
            var aDao = new AlunoDAO();
            aDao.adicionar(a);

            //var assistente = new AssistenteAluno()
            //{
            //    area = "Assistentecia",
            //    celular = "199283723",
            //    nascimento = new DateTime(1984, 04, 04),
            //    nome = "Lucia Almeida Soares",
            //    prontuario = new Prontuario()
            //    {
            //        prontuario = "1400020",
            //    },
            //    rg = "39846263",
            //    sexo = 'F',
            //    telefone = "34920493"
            //};
            //var assisteteDAO = new AssistenteAlunoDAO();
            //assisteteDAO.adicionar(assistente);
            //var a = aDao.find(2);
            //Assert.AreEqual(a.nome, "Muher do Vitor");
            //Assert.AreEqual(a.idPessoaFisica, 2);

            //var aDao = new AlunoDAO();
            //Aluno aluno = aDao.get(a => a.prontuario.prontuario == "1320010").FirstOrDefault();
            //Assert.AreEqual(1, aluno.idPessoaFisica);

            //var p = new Porteiro()
            //{
            //    area = "Portaria",
            //    empresa = "SA Vigilantes e Porteiros",
            //    celular = "1900000000",
            //    nascimento = new DateTime(1976, 04, 04),
            //    nome = "Samuel Oliveira da Silva",
            //    rg = "490008888",
            //    sexo = 'M',
            //    telefone = "1934910000",
            //};
            //var pDao = new PorteiroDAO();
            //pDao.adicionar(p);
        }
    }
}
