using Microsoft.Extensions.DependencyInjection;
using SVRepository.Implementation;
using SVRepository.Interfaces;
using SVServices.Implementation;
using SVServices.Interfaces;

namespace SVServices
{
    public static class DependencyInjection
    {
        public static void RegisterServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<INegocioService, NegocioService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
        }
    }
}
