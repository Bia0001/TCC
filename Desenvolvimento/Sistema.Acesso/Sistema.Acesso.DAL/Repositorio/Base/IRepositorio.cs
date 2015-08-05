using System;
using System.Linq;

/* Interface que possui métodos crud para serem implementados */

namespace Sistema.Acesso.DAL.Repositorio.Base
{
    interface IRepositorio<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Atualizar(TEntity obj);
        void Commit();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);
    }
}
