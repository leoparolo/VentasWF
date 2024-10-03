using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> lista(string buscar = "");
        Task<string> Crear(Categoria objeto);
        Task<string> Editar(Categoria objeto);
    }
}
