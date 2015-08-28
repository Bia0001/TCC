using Sistema.Ifsp.Repositorio;
using Sistema.Ifsp.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.DAO
{
    public class AlunoDAO

    {
        /*instância do contexto do banco de dados*/
        private BancoContexto contexto;
        public AlunoDAO()
        {
            contexto = RepositorioBanco.GetInstance();
        }

        /*metodo para adicionar persistir um novo registro de Aluno*/
        public void Adicionar(Aluno aluno)
        {
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }

        /*metodo para buscar todos alunos registrados*/
        public IQueryable<Aluno> Todos()
        {
            return contexto.Alunos;
        }

        /*método para pesquisar todos alunos cuja iniciais sejam iguais ao informado como argumento*/
        public IEnumerable<Aluno> Pesquisar(string letras)
        {
            return contexto.Alunos.Where(a => a.nome.StartsWith(letras));
        }

        /*método para pesquisar aluno por ID*/
        public Aluno Pesquisar(int id)
        {
            return contexto.Alunos.Find(id);
        }

        /*método para pesqusar aluno por prontuário*/
        public Aluno PesquisarProntuario(string prontuario)
        {
            return contexto.Alunos.Where(a => a.Prontuario.prontuario == prontuario).FirstOrDefault();
        }

        /*método para atualizar registro de aluno*/
        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        /*método para deletar aluno*/
        public void Delete(int id)
        {
            Aluno aluno = contexto.Alunos.Where(x => x.idPessoaFisica == id).First();
            contexto.Set<Aluno>().Remove(aluno);
            contexto.SaveChanges();
        }
    }
}
