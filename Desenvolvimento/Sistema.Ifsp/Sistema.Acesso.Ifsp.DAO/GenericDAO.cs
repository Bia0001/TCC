using Sistema.Acesso.Ifsp.DAL;
using System;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Acesso.Ifsp.DAO
{
    public abstract class GenericDAO<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        BancoContexto ctx = RepositorioBanco.GetInstance();
        /*Busca todos registros da entidade*/
        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }
        
        /* a => a.Idade == 35*/
        /*Busca todos os registro mediante um criterio*/
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        /*Busca um registro pela chave primaria*/
        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        /*Efetiva as alterações no banco de dados*/
        public void Commit()
        {
            ctx.SaveChanges();
        }

        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }
    }
}
