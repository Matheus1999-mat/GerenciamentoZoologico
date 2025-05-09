using GerenciamentoZoologico.Models;

namespace GerenciamentoZoologico.Repositories.Interfaces
{
    public interface ICuidadosRepository
    {
        Task<List<Cuidados>> ObterTodosCuidados();
        Task<Cuidados> ObterCuidadolById(int id);
        Task<Cuidados> AdicionarCuidados(Cuidados cuidados);
        Task<Cuidados> AtualizarCuidado(Cuidados cuidados, int id);
        Task<bool> DeletarCuidado(int id);
    }
}
