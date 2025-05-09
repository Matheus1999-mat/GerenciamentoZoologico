using GerenciamentoZoologico.Models;

namespace GerenciamentoZoologico.Repositories.Interfaces
{
    public interface IAnimaisRepository
    {
        Task<List<Animais>> ObterTodosAnimais();
        Task<Animais> ObterAnimalById(int id);

        Task<Animais> AdicionarAnimais(Animais animais);
        Task<Animais> AtualizarAnimal(Animais animais, int id);
        Task<bool> DeletarAnimal(int id);
    }
}
