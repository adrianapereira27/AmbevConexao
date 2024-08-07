using AmbevConexao.Domain.Model;

namespace AmbevConexao.Data.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>    // BaseRepository usa Generics
    {
        /*protected readonly Contexto contexto;   // não é usado, pois está sendo usado Generics
        public AlunoRepository()
        {
            contexto = new Contexto();
        }*/

        /*public List<Aluno> SelecionarTudo()
        {
            return contexto.Aluno.ToList();
        }*/

       /*public void Incluir(Aluno aluno)   // usado no Generics
        {
            contexto.Aluno.Add(aluno);
            contexto.SaveChanges();
        }*/

        /*public void Alterar(Aluno aluno)
        {
            contexto.Aluno.Update(aluno);
            contexto.SaveChanges();
        }*/

        public Aluno SelecionarPorId(int id)
        {
            return contexto.Aluno.FirstOrDefault(x => x.Id == id);

            //return contexto.Aluno.Find(id);

        }

        /*public void Excluir(int id)
        {
            var aluno = SelecionarPorId(id);
            contexto.Aluno.Remove(aluno);
            contexto.SaveChanges();
        }*/

        /*public void Dispose()   // libera espaço na memória (executa o garbage colector)
        {
            contexto.Dispose();
        }*/

    }
}
