using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoZoologico.Controllers
{
    [ApiController]
    [Route("api/animais")]
    
    public class AnimaisController : ControllerBase
    {
        private readonly IAnimaisRepository _animaisRepository;
        public AnimaisController(IAnimaisRepository animaisRepository)
        {
            _animaisRepository = animaisRepository;
        }
        [HttpPost]
        public async Task<ActionResult<Animais>> AdicionarAnimais([FromBody] Animais animais)
        {
            Animais cadastrarAnimais = await _animaisRepository.AdicionarAnimais(animais);
            return Ok(cadastrarAnimais);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Animais>> AtualizarAnimal([FromBody] Animais animais, int id)
        {
            animais.AnimalId = id;
            Animais animalAtualizado= await _animaisRepository.AtualizarAnimal(animais,id);
            return Ok(animalAtualizado);
        }
        [HttpDelete("{id}")]
        public async Task <ActionResult<Animais>>DeletarAnimal(int id)
        {
            bool animalDeletado = await _animaisRepository.DeletarAnimal(id);
            return Ok(animalDeletado);

        }

        [HttpGet]
        public async Task<ActionResult<List<Animais>>> ObterTodosAnimais()
        {
            List<Animais> animais = await _animaisRepository.ObterTodosAnimais();
            return Ok(animais);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Animais>> ObterAnimalById(int id)
        {
            Animais animais = await _animaisRepository.ObterAnimalById(id);
            return Ok(animais);
        }

        
    }
}
