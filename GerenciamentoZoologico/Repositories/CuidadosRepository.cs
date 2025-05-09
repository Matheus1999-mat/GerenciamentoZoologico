using GerenciamentoZoologico.Data;
using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoZoologico.Repositories
{
    public class CuidadosRepository : ICuidadosRepository
    {
        private readonly GerenciamentoZoologicoDBContext _dbContext;
        public CuidadosRepository(GerenciamentoZoologicoDBContext gerenciamentoZoologicoDBContext)
        {
            _dbContext = gerenciamentoZoologicoDBContext;
        }
        public async Task<Cuidados> AdicionarCuidados(Cuidados cuidados)
        {
            await _dbContext.Cuidados.AddAsync(cuidados);
            await _dbContext.SaveChangesAsync();
            return cuidados; 
        }

        public async Task<Cuidados> AtualizarCuidado(Cuidados cuidados, int id)
        {
            Cuidados cuidadoById = await ObterCuidadolById(id);
            if (cuidadoById == null)
            {
                throw new Exception("Cuidado não encontrado.");
            }
            cuidadoById.NomeCuidado = cuidados.NomeCuidado;
            cuidadoById.Descricao = cuidados.Descricao;
            cuidadoById.Frequencia = cuidados.Frequencia;
            
            _dbContext.Cuidados.Update(cuidadoById);
            await _dbContext.SaveChangesAsync();
            return cuidadoById;
        }

        public async Task<bool> DeletarCuidado(int id)
        {
            Cuidados cuidadoById = await ObterCuidadolById(id);
            if (cuidadoById == null)
            {
                throw new Exception("Cuidado não encontrado.");
            }
            _dbContext.Cuidados.Remove(cuidadoById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cuidados> ObterCuidadolById(int id)
        {
            return await _dbContext.Cuidados.FirstOrDefaultAsync(x => x.CuidadoId == id);
        }

        public async Task<List<Cuidados>> ObterTodosCuidados()
        {
            return await _dbContext.Cuidados.ToListAsync();
        }
    }
}
