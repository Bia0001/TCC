using System;
using System.Linq;

namespace Sistema.Ifsp.DAO
{
    interface ICRUD<TEntity> where TEntity : class
    {
        IQueryable<TEntity> getAll();
        IQueryable<TEntity> get(Func<TEntity, bool> predicate);
        TEntity find(params object[] key);
        bool atualizar(TEntity obj);
        bool adicionar(TEntity obj);
        bool excluir(Func<TEntity, bool> predicate);
    }
}
