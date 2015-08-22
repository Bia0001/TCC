using Sistema.Ifsp.Model;
using Sistema.Ifsp.Repositorio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.BO
{
    public class AssistenteAlunoBO
    {
        private BancoContexto contexto;
        public AssistenteAlunoBO()
        {
            contexto = RepositorioBanco.GetInstance();
        }

        public void Adicionar(AssistenteAluno assistente)
        {
            contexto.AssistentesAluno.Add(assistente);
            contexto.SaveChanges();
        }

        public IEnumerable<AssistenteAluno> Pesquisar(string letras)
        {
            return contexto.AssistentesAluno.Where(a => a.nome.StartsWith(letras));
        }

        public AssistenteAluno Pesquisar(int id)
        {
            return contexto.AssistentesAluno.Find(id);
        }

        public AssistenteAluno PesquisarProntuario(string prontuario)
        {
            return contexto.AssistentesAluno.Where(a => a.Prontuario.prontuario == prontuario).FirstOrDefault();
        }

        public void Atualizar(AssistenteAluno assistente)
        {
            contexto.Entry(assistente).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            var assistente = contexto.AssistentesAluno.Where(a => a.idPessoaFisica == id).First();
            contexto.Set<AssistenteAluno>().Remove(assistente);
            contexto.SaveChanges();
        }
    }
}
