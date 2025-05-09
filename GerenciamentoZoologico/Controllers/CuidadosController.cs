using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoZoologico.Controllers
{
    [ApiController]
    [Route("api/cuidados")]
    
    public class CuidadosController : ControllerBase
    {
        private readonly ICuidadosRepository _cuidadosRepository;
        public CuidadosController(ICuidadosRepository cuidadosRepository)
        {
            _cuidadosRepository = cuidadosRepository;
        }
        [HttpPost]
        public async Task<ActionResult<Cuidados>> AdicionarCuidados([FromBody] Cuidados cuidados)
        {
            Cuidados cadastrarCuidados = await _cuidadosRepository.AdicionarCuidados(cuidados);
            return Ok(cadastrarCuidados);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Cuidados>> AtualizarCuidado([FromBody] Cuidados cuidados, int id)
        {
            cuidados.CuidadoId = id;
            Cuidados cuidadoAtualizado= await _cuidadosRepository.AtualizarCuidado(cuidados,id);
            return Ok(cuidadoAtualizado);
        }
        [HttpDelete("{id}")]
        public async Task <ActionResult<Cuidados>>DeletarCuidado(int id)
        {
            bool cuidadoDeletado = await _cuidadosRepository.DeletarCuidado(id);
            return Ok(cuidadoDeletado);

        }

        [HttpGet]
        public async Task<ActionResult<List<Cuidados>>> ObterTodosCuidados()
        {
            List<Cuidados> cuidados = await _cuidadosRepository.ObterTodosCuidados();
            return Ok(cuidados);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuidados>> ObterCuidadoById(int id)
        {
            Cuidados cuidados = await _cuidadosRepository.ObterCuidadolById(id);
            return Ok(cuidados);
        }

        
    }
}
