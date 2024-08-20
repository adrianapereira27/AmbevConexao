using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Repositories;

namespace AmbevConexao.Data.Repository
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository  // BaseRepository implementa o Generics
    {
        public TurmaRepository(Contexto contexto) : base(contexto) { }

        /*
        public List<Turma> SelecionarTudo()
        {
            return contexto.Turma.ToList();
        }

        public void Incluir(Turma turma)
        {
            contexto.Turma.Add(turma);
            contexto.SaveChanges();
        }

        public void Alterar(Turma turma)
        {
            contexto.Turma.Update(turma);
            contexto.SaveChanges();
        }

        public Turma SelecionarPorId(int id)
        {
            return contexto.Turma.FirstOrDefault(x => x.Id == id);

            //return contexto.Turma.Find(id);

        }

        public void Excluir(int id)
        {
            var turma = SelecionarPorId(id);
            contexto.Turma.Remove(turma);
            contexto.SaveChanges();
        }*/
    }
}
