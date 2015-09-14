using Sistema.Ifsp.DAL;
using System;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.Dao
{
    /*implementando métodos de persistência genéricos que servira todos as c*/
    public abstract class CRUD<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        Contexto ctx = AcessoContexto.GetInstance();

        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>().Where(predicate).ToList().ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        /*pesquisar através do atributo chave*/
        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        /*recebe como parametro uma empressão Lambda como critério 
        de pesqusia e retorna uma lista de registros*/
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        /*traz todos os registro de uma tabela*/
        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }

        /*eftiva no banco de dados todas as alterações realizadas em memória*/
        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }
    }
}
