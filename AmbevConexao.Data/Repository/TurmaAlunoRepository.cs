using AmbevConexao.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AmbevConexao.Data.Repository
{
    public class TurmaAlunoRepository : BaseRepository<TurmaAluno>
    {
        /*protected readonly Contexto contexto;
        public TurmaAlunoRepository()
        {
            contexto = new Contexto();
        }*/

        public List<TurmaAluno> SelecionarTudoCompleto()
        {
            return contexto.TurmaAluno
                .Include(x => x.Aluno)
                .Include(x => x.Turma)
                //.ThenInclude(x => x.Professor)   // ThenInclude é usada, pois o Porfessor está referenciada na classe Turma
                .ToList();
        }


        /*public List<TurmaAluno> SelecionarTudo()
        {
            return contexto.TurmaAluno.ToList();
        }

        public void Incluir(TurmaAluno turmaAluno)
        {
            contexto.TurmaAluno.Add(turmaAluno);
            contexto.SaveChanges();
        }

        public void Alterar(TurmaAluno turmaAluno)
        {
            contexto.TurmaAluno.Update(turmaAluno);
            contexto.SaveChanges();
        }

        public TurmaAluno SelecionarPorId(int id)
        {
            return contexto.TurmaAluno.FirstOrDefault(x => x.Id == id);

            //return contexto.TurmaAluno.Find(id);

        }

        public void Excluir(int id)
        {
            var turma = SelecionarPorId(id);
            contexto.Turma.Remove(turma);
            contexto.SaveChanges();
        }*/

    }
}
