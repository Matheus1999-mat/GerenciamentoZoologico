namespace GerenciamentoZoologico.Models
{
    public class Animais
    {
        public int AnimalId { get; set; }
        public string Nome {  get; set; }
        public int CuidadoID {  get; set; }
        public string Descricao { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Especie { get; set; }
        public string Habitat { get; set; }
        public string PaisOrigem { get; set; }
    }
}
