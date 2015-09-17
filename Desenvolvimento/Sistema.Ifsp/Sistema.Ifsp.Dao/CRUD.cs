using Sistema.Ifsp.DAL;
using System;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.DAO
{
    /*implementando métodos de persistência genéricos que servira todos as c*/
    public abstract class CRUD<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        Contexto ctx = AcessoContexto.GetInstance();

        public bool adicionar(TEntity obj)
        {
            try
            {
                ctx.Set<TEntity>().Add(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            

        }

        public bool atualizar(TEntity obj)
        {
            try
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool excluir(Func<TEntity, bool> predicate)
        {
            try
            {
                ctx.Set<TEntity>().Where(predicate).ToList().ForEach(del => ctx.Set<TEntity>().Remove(del));
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        /*pesquisar através do atributo chave*/
        public TEntity find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        /*recebe como parametro uma empressão Lambda como critério 
        de pesqusia e retorna uma lista de registros*/
        public IQueryable<TEntity> get(Func<TEntity, bool> predicate)
        {
            return getAll().Where(predicate).AsQueryable();
        }

        /*traz todos os registro de uma tabela*/
        public IQueryable<TEntity> getAll()
        {
            return ctx.Set<TEntity>();
        }
    }
}
