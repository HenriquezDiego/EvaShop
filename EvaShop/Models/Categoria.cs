﻿namespace EvaShop.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Imagen { get; set; }
        public List<SubCategoria> SubCategorias { get; set; }
    }
}