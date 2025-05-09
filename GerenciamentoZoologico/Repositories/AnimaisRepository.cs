using GerenciamentoZoologico.Data;
using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoZoologico.Repositories
{
    public class AnimaisRepository : IAnimaisRepository
    {
        private readonly GerenciamentoZoologicoDBContext _dbContext;
        public AnimaisRepository(GerenciamentoZoologicoDBContext gerenciamentoZoologicoDBContext)
        {
            _dbContext = gerenciamentoZoologicoDBContext;
        }
        public async Task<Animais> AdicionarAnimais(Animais animais)
        {
            await _dbContext.Animais.AddAsync(animais);
            await _dbContext.SaveChangesAsync();
            return animais;
        }

        public async Task<Animais> AtualizarAnimal(Animais animais, int id)
        {
            Animais animalById = await ObterAnimalById(id);
            if (animalById == null)
            {
                throw new Exception("Animal não encontrado.");
            }
            animalById.Nome = animais.Nome;
           animalById.CuidadoID = animais.CuidadoID;
            animalById.Descricao = animais.Descricao;
            animalById.DataNascimento = animais.DataNascimento;
            animalById.Especie = animais.Especie;
            animalById.Habitat = animais.Habitat;
            animalById.PaisOrigem = animais.PaisOrigem;
            _dbContext.Animais.Update(animalById);
            await _dbContext.SaveChangesAsync();
            return animalById;
        }

        public async Task<List<Animais>> ObterTodosAnimais()
        {
            return await _dbContext.Animais.ToListAsync();
        }

        public async Task<bool> DeletarAnimal(int id)
        {
            Animais animalById = await ObterAnimalById(id);
            if (animalById == null)
            {
                throw new Exception("Animal não encontrado.");
            }
            _dbContext.Animais.Remove(animalById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Animais> ObterAnimalById(int id)
        {
            return await _dbContext.Animais.FirstOrDefaultAsync(x => x.AnimalId == id);
        }

        

        
    }
}
