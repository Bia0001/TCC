using Sistema.Ifsp.Model;
using Sistema.Ifsp.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.BO
{
    public class SolicitacaoSaidaBO
    {
        private BancoContexto contexto;
        public SolicitacaoSaidaBO()
        {
            contexto = RepositorioBanco.GetInstance();
        }
        public void Adicionar(SolicitacaoSaida solicitacao)
        {
            contexto.SolicitacoesSaida.Add(solicitacao);
            contexto.SaveChanges();
        }
        public SolicitacaoSaida Pesquisar(int id)
        {
            return contexto.SolicitacoesSaida.Find(id);
        }
        public void Atualizar(SolicitacaoSaida solicitacao)
        {
            contexto.Entry(solicitacao).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            var solicitacao = contexto.SolicitacoesSaida.Where(s => s.idSolicitacaoSaida == id).First();
            contexto.Set<SolicitacaoSaida>().Remove(solicitacao);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

        /*Finalizando solicitação*/
        public void Finalizar(SolicitacaoSaida solicitacao, Vigilante vigilante)
        {
            /*Verificando se essa solicitação ja foi finalizada*/
            if (Pesquisar(solicitacao.idSolicitacaoSaida).status == "Encerrado")
            {
                throw new Exception("Atenção! Essa solicitação já foi encerrada"
                    + "\nSe desejar verifique a aba de \"Solicitações Encerradas\" após 30 segundos para verificar quem há encerrou");
            }
            /*Atualizando solicitação como encerrada*/
            else
            {
                solicitacao.encerramento = DateTime.Now;
                solicitacao.Vigilante = vigilante;
                solicitacao.status = "Encerrado";
                Atualizar(solicitacao);
                contexto.SaveChanges();
            }
        }

        /*Pegando todas as solicitações de hoje e atualizando seus status*/
        public IEnumerable<SolicitacaoSaida> PesquisarSolicitacoesHoje()
        {
            var dt = DateTime.Now;
            var solicitacoes = contexto.SolicitacoesSaida.Where(s => s.abertura.Day == DateTime.Now.Day &&
            s.abertura.Month == dt.Month && s.abertura.Year == dt.Year).ToList();
            foreach (SolicitacaoSaida s in solicitacoes)
            {
                /*Verificando se previsão de encerramento foi atingida para determinar expiração*/
                if (s.status == "Aberto" && s.previsaoEncerramento < DateTime.Now)
                {
                    /*Se sim, atualiza status para "Expirado"*/
                    s.status = "Expirado";
                    Atualizar(s);
                    contexto.SaveChanges();
                    /*Chamamos novamente o método para uma reverificação de status (Recursividade)*/
                    PesquisarSolicitacoesHoje();
                }
            }
            /*Retornando solicitação com status atualizado*/
            return solicitacoes;
        }
    }
}
