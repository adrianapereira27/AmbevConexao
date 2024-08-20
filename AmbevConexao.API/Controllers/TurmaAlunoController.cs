using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaAlunoController : ControllerBase
    {
        private readonly ITurmaAlunoRepository _repository;

        public TurmaAlunoController(ITurmaAlunoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<TurmaAluno> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public TurmaAluno Get(int id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TurmaAluno> Post([FromBody] TurmaAluno turmaAluno)
        {
            var turmaAlunoEntidade = TurmaAluno.MatricularAluno(turmaAluno.IdAluno, turmaAluno.IdTurma);

            _repository.Incluir(turmaAlunoEntidade);

            return _repository.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Excluir(id);

        }

    }
}
