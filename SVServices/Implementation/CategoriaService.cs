﻿using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<List<Categoria>> lista(string buscar = "")
        {
            return await _categoriaRepository.lista(buscar);
        }

        public async Task<string> Crear(Categoria objeto)
        {
            return await _categoriaRepository.Crear(objeto);
        }

        public async Task<string> Editar(Categoria objeto)
        {
            return await _categoriaRepository.Editar(objeto);
        }

        
    }
}
