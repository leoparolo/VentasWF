﻿
namespace SVRepository.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int Activo { get; set; }
        public Medida ReMedida { get; set; }
    }
}
