
using AmbevConexao.Data;
using AmbevConexao.Data.Repository;
using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Model.Enum;

class Program
{
    static void Main(string[] args)
    {        

        /*IncluirAluno();
        var alunos = ConsultarTodosAlunos();

        if (alunos?.Count > 1)
        {
            AlterarNomeAluno(alunos[0]);
            ExcluirAluno(alunos[1].Id);
        }*/

        /*IncluirProfessor();
        var professores = ConsultarTodosProfessores();

        if (professores?.Count > 1)
        {
            AlterarNomeProfessor(professores[0]);
            ExcluirProfessor(professores[1].Id);
        }*/
    }
    /*private static void IncluirAluno()
    {
        using (var contexto = new Contexto())
        {
            var repoAluno = new AlunoRepository(contexto);
            repoAluno.Incluir(Aluno.NovoAluno("Adriana"));
            repoAluno.Incluir(Aluno.NovoAluno("Rodrigo"));
            repoAluno.Incluir(Aluno.NovoAluno("Amanda"));
        }
    }
    private static void AlterarNomeAluno(Aluno aluno)
    {
        using (var contexto = new Contexto())
        {
            var repoAluno = new AlunoRepository(contexto);
            repoAluno.Alterar(aluno.AlterarNome("Adriana Pereira"));
        }
    }
    private static List<Aluno> ConsultarTodosAlunos()
    {
        using (var contexto = new Contexto())
        {
            var repoAluno = new AlunoRepository(contexto);
            return repoAluno.SelecionarTudo();
        }
    }
    private static void ExcluirAluno(int id)
    {
        using (var contexto = new Contexto())
        {
            var repoAluno = new AlunoRepository(contexto);
            repoAluno.Excluir(id);
        }
    }
    private static void IncluirProfessor()
    {
        using (var contexto = new Contexto())
        {
            var repoProfessor = new ProfessorRepository(contexto);
            repoProfessor.Incluir(Professor.NovoProfessor("Maria", "maria@gmail.com", Turno.Manha));
            repoProfessor.Incluir(Professor.NovoProfessor("Jose", "jose@gmail.com", Turno.Tarde));
            repoProfessor.Incluir(Professor.NovoProfessor("Luisa", "luisa@gmail.com", Turno.Integral));
        }
    }
    private static void AlterarNomeProfessor(Professor professor)
    {
        using (var contexto = new Contexto())
        {
            var repoProfessor = new ProfessorRepository(contexto);
            repoProfessor.Alterar(professor.AlterarNome("Maria Joaquina"));
        }
    }
    private static List<Professor> ConsultarTodosProfessores()
    {
        using (var contexto = new Contexto())
        {
            var repoProfessor = new ProfessorRepository(contexto);
            return repoProfessor.SelecionarTudo();
        }
    }
    private static void ExcluirProfessor(int id)
    {
        using (var contexto = new Contexto())
        {
            var repoProfessor = new ProfessorRepository(contexto);
            repoProfessor.Excluir(id);
        }
    }
    private static void SelecionarTurmaAluno()
    {
        using (var contexto = new Contexto())
        {
            TurmaAlunoRepository repo = new TurmaAlunoRepository(contexto);

            var dados = repo.SelecionarTudo();

            TurmaAlunoRepository repo1 = new TurmaAlunoRepository(contexto);

            var dadosCompletos = repo1.SelecionarTudoCompleto();
        }
    }*/
}
