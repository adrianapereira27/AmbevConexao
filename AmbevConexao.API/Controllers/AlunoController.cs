using AmbevConexao.API.Dto;
using AmbevConexao.API.Filtros;
using AmbevConexao.Data;
using AmbevConexao.Domain.Model;
using AmbevConexao.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;        

        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> Get()
        {
            var alunos = _repository.SelecionarTudo();
            return alunos == null ? NotFound() : alunos;
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> Get(int id)
        {
            var aluno = _repository.Selecionar(id);

            if (aluno == null) throw new NotFoundException($"O aluno com id {id} não existe em nosso sistema");

            return aluno;
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] AlunoDto alunoDto)
        {
            var alunoEntidade = Aluno.NovoAluno(alunoDto.Nome);

            _repository.Incluir(alunoEntidade);

            return _repository.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] AlunoDto alunoDto)
        {
            var alunoEntidade = _repository.Selecionar(id);

            alunoEntidade.AlterarNome(alunoDto.Nome);

            _repository.Alterar(alunoEntidade);

            return alunoEntidade;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Excluir(id);

        }

    }
}
