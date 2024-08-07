using AmbevConexao.Domain.Model;

namespace AmbevConexao.Data.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>    // BaseRepository implementa o Generics
    {
        /*protected readonly Contexto contexto;
        public ProfessorRepository()
        {
            contexto = new Contexto();
        }*/

        /*public List<Professor> SelecionarTudo()
        {
            return contexto.Professor.ToList();
        }*/

        /*public void Incluir(Professor professor)
        {
            contexto.Professor.Add(professor);
            contexto.SaveChanges();
        }*/

        /*public void Alterar(Professor professor)
        {
            contexto.Professor.Update(professor);
            contexto.SaveChanges();
        }*/

        public Professor SelecionarPorId(int id)
        {
            return contexto.Professor.FirstOrDefault(x => x.Id == id);

            //return contexto.Professor.Find(id);

        }

       /* public void Excluir(int id)
        {
            var professor = SelecionarPorId(id);
            contexto.Professor.Remove(professor);
            contexto.SaveChanges();
        }*/

        /*public void Dispose()    // libera espaço na memória (executa o garbage colector)
        {
            contexto.Dispose();
        }*/
    }
}
