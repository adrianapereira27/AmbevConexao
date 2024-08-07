﻿using AmbevConexao.Domain.Model;

namespace AmbevConexao.Data.Repository
{
    public class BaseRepository<T> where T : class, IEntity    // nesta classe é usada Generics
    {
        protected readonly Contexto contexto;

        public BaseRepository()
        {
            contexto = new Contexto();
        }

        public void Incluir(T entity)
        {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
        }

        public void Alterar(T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }
        public T Selecionar(int id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return contexto.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()    // libera espaço na memória (executa o garbage colector)
        {
            contexto.Dispose();
        }
    }
}
