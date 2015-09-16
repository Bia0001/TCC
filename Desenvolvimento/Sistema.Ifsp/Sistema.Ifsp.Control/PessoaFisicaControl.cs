using Sistema.Ifsp.Dao;
using Sistema.Ifsp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Ifsp.Control
{
    public class PessoaFisicaControl
    {
        public virtual bool cadastrar(string nome, string rg, string celular, string telefone, char sexo, DateTime nascimento)
        {
            try
            {
                var p = new PessoaFisica();
                p.celular = celular;
                p.nascimento = nascimento;
                p.nome = nome;
                p.sexo = sexo;
                p.telefone = telefone;
                p.rg = rg;
                var pDao = new PessoaFisicaDAO();
                if (pDao.adicionar(p))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao persistir pessoa fisica. Detalhes: " + ex);
            }
        }
    }
}
