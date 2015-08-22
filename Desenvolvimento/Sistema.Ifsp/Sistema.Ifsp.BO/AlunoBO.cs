using Sistema.Ifsp.Repositorio;
using Sistema.Ifsp.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.BO
{
    public class AlunoBO
    {
        private BancoContexto contexto;
        public AlunoBO()
        {
            contexto = RepositorioBanco.GetInstance();
        }

        public void Adicionar(Aluno aluno)
        {
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }

        public IEnumerable<Aluno> Pesquisar(string letras)
        {
            return contexto.Alunos.Where(a => a.nome.StartsWith(letras));
        }

        public Aluno Pesquisar(int id)
        {
            return contexto.Alunos.Find(id);
        }
        public Aluno PesquisarProntuario(string prontuario)
        {
            return contexto.Alunos.Where(a => a.Prontuario.prontuario == prontuario).FirstOrDefault();
        }

        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            Aluno aluno = contexto.Alunos.Where(x => x.idPessoaFisica == id).First();
            contexto.Set<Aluno>().Remove(aluno);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
