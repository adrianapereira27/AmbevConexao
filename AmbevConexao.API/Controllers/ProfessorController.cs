using AmbevConexao.API.Dto;
using AmbevConexao.Data;
using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepository _repository;        

        public ProfessorController(IProfessorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Professor> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Professor Get(int id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Professor> Post([FromBody] ProfessorDto professor)
        {
            var professorEntidade = Professor.NovoProfessor(professor.Nome, professor.Email, professor.Turno);

            _repository.Incluir(professorEntidade);

            return _repository.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public Professor Put(int id, [FromBody] ProfessorDto professor)
        {
            var professorEntidade = _repository.Selecionar(id);

            professorEntidade.AlterarNome(professor.Nome);

            _repository.Alterar(professorEntidade);

            return professorEntidade;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Excluir(id);

        }
    }
}
