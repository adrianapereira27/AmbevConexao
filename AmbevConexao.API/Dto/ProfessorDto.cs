﻿using AmbevConexao.Domain.Model.Enum;

namespace AmbevConexao.API.Dto
{
    public class ProfessorDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Turno Turno { get; set; }
    }
}
