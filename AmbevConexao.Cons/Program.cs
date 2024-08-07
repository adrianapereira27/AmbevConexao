// See https://aka.ms/new-console-template for more information

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

        IncluirProfessor();
        var professores = ConsultarTodosProfessores();

        if (professores?.Count > 1)
        {
            AlterarNomeProfessor(professores[0]);
            ExcluirProfessor(professores[1].Id);
        }


    }

    private static void IncluirAluno()
    {
        var repoAluno = new AlunoRepository();
        repoAluno.Incluir(Aluno.NovoAluno("Adriana"));
        repoAluno.Incluir(Aluno.NovoAluno("Rodrigo"));
        repoAluno.Incluir(Aluno.NovoAluno("Amanda"));
    }

    private static void AlterarNomeAluno(Aluno aluno)
    {
        var repoAluno = new AlunoRepository();
        repoAluno.Alterar(aluno.AlterarNome("Adriana Pereira"));
    }

    private static List<Aluno> ConsultarTodosAlunos()
    {
        var repoAluno = new AlunoRepository();
        return repoAluno.SelecionarTudo();
    }

    private static void ExcluirAluno(int id)
    {
        var repoAluno = new AlunoRepository();
        repoAluno.Excluir(id);
    }

    private static void IncluirProfessor()
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Incluir(Professor.NovoProfessor("Maria", "maria@gmail.com", Turno.Manha));
        repoProfessor.Incluir(Professor.NovoProfessor("Jose", "jose@gmail.com", Turno.Tarde));
        repoProfessor.Incluir(Professor.NovoProfessor("Luisa", "luisa@gmail.com", Turno.Integral));
    }

    private static void AlterarNomeProfessor(Professor professor)
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Alterar(professor.AlterarNome("Maria Joaquina"));
    }

    private static List<Professor> ConsultarTodosProfessores()
    {
        var repoProfessor = new ProfessorRepository();
        return repoProfessor.SelecionarTudo();
    }

    private static void ExcluirProfessor(int id)
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Excluir(id);
    }

    private static void SelecionarTurmaAluno()
    {
        TurmaAlunoRepository repo = new TurmaAlunoRepository();

        var dados = repo.SelecionarTudo();

        TurmaAlunoRepository repo1 = new TurmaAlunoRepository();

        var dadosCompletos = repo1.SelecionarTudoCompleto();        
    }
}
