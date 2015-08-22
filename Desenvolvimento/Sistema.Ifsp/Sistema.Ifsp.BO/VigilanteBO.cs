using Sistema.Ifsp.Model;
using Sistema.Ifsp.Repositorio;

namespace Sistema.Ifsp.BO
{
    public class VigilanteBO
    {
        private BancoContexto contexto;
        public VigilanteBO()
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
    }
}
