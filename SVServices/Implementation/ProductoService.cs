﻿
using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public async Task<List<Producto>> lista(string buscar = "")
        {
            return await _productoRepository.lista(buscar);
        }

        public async Task<string> Crear(Producto objeto)
        {
            return await _productoRepository.Crear(objeto);
        }

        public async Task<string> Editar(Producto objeto)
        {
            return await _productoRepository.Editar(objeto);
        }

        
    }
}
