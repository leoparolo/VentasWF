using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface INegocioRepository
    {
        Task<Negocio> Obtener();
        Task Edtiar(Negocio objeto);
    }
}
