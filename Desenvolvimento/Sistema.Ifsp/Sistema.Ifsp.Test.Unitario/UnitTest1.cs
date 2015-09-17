using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistema.Ifsp.Model;

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
                nome = "Willian Moraes Fuent",
                prontuario = new Prontuario()
                {
                    prontuario = "1320010"
                },
                responsavel1 = "Wagner Antunes Fuent",
                responsavel2 = "Mafalda Pereira Moraes",
                rg = "507382748",
                sexo = 'M',
                telefone = "19966338844"
            };
        }
    }
}
