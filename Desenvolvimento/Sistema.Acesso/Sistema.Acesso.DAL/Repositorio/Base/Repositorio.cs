using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.Entity;
using Sistema.Acesso.DAL.Contexto;

namespace Sistema.Acesso.DAL.Repositorio.Base
{
    /* Essa classe é servidora de uma classe qualquer que é representada por TEntity (trate TEntity como se fosse um argumento)
       ela tamnbém herda de IRepositorio e IDisposible*/
    public abstract class Repositorio<TEntity> : IDisposable, IRepositorio<TEntity> where TEntity : class
    {
        /* Instânciando o contexto que representa o banco de dados*/
        BancoContexto contexto = new BancoContexto();

        /* Retorna todos os registros de uma consulta como uma lista*/
        public IQueryable<TEntity> GetAll()
        {
            return contexto.Set<TEntity>();
        }

        /* Retorna todos os registros que atendam o critério, utiliza-se empressão Lambda como critério*/
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        /* Retorna o registro segundo atributo chave, seja ele um atributo chave ou chave composta*/
        public TEntity Find(params object[] key)
        {
            return contexto.Set<TEntity>().Find(key);
        }

        /* Atualiza o registro*/
        public void Atualizar(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
        }

        /* Efetiva todas as atualizações do contexto no banco de dados*/
        public void Commit()
        {
            contexto.SaveChanges();
        }

        /* Adiciona registro*/
        public void Adicionar(TEntity obj)
        {
            contexto.Set<TEntity>().Add(obj);
        }

        /* Excluir registros que atendam um critério*/
        public void Excluir(Func<TEntity, bool> predicate)
        {
            contexto.Set<TEntity>().Where(predicate).ToList().ForEach(del => contexto.Set<TEntity>().Remove(del));
        }

        /* usado para destrui objeto em memoria*/
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
