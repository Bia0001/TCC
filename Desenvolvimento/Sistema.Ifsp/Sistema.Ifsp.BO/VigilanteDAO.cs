using Sistema.Ifsp.Model;
using Sistema.Ifsp.Repositorio;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.DAO
{
    public class VigilanteDAO
    {
        private BancoContexto contexto;
        public VigilanteDAO()
        {
            contexto = RepositorioBanco.GetInstance();
        }

        public void Adicionar(Vigilante vigilante)
        {
            contexto.Vigilantes.Add(vigilante);
            contexto.SaveChanges();
        }
        public Vigilante Pesquisar(int id)
        {
            return contexto.Vigilantes.Find(id);
        }

        /*metodo para buscar todos alunos registrados*/
        public IQueryable<Vigilante> Todos()
        {
            return contexto.Vigilantes;
        }

        /*método para atualizar registro de aluno*/
        public void Atualizar(Vigilante vigilante)
        {
            contexto.Entry(vigilante).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        /*método para deletar aluno*/
        public void Delete(int id)
        {
            Vigilante vigilante = contexto.Vigilantes.Where(v => v.idPessoaFisica == id).First();
            contexto.Set<Vigilante>().Remove(vigilante);
            contexto.SaveChanges();
        }
    }
}
