using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface INegocioService
    {
        Task<Negocio> Obtener();
        Task Edtiar(Negocio objeto);
    }
}
