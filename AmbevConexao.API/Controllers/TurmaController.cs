using AmbevConexao.API.Dto;
using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository _repository;

        public TurmaController(ITurmaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] TurmaDto turma)
        {
            var turmaEntidade = Turma.NovaTurma(turma.Nome, turma.IdProfessor);

            _repository.Incluir(turmaEntidade);

            return _repository.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public Turma Put(int id, [FromBody] TurmaDto turma)
        {
            var turmaEntidade = _repository.Selecionar(id);

            turmaEntidade.AlterarNome(turma.Nome);

            _repository.Alterar(turmaEntidade);

            return turmaEntidade;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Excluir(id);

        }

    }
}
