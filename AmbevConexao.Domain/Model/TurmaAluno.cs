﻿namespace AmbevConexao.Domain.Model
{
    public class TurmaAluno : IEntity
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public Aluno Aluno { get; set; }
        public int IdTurma { get; set; }
        public Turma Turma { get; set; }

        public static TurmaAluno MatricularAluno(int idAluno, int idTurma)
        {
            var matricula = new TurmaAluno();   
            matricula.IdAluno = idAluno;
            matricula.IdTurma = idTurma;

            return matricula;
        }

    }
}
