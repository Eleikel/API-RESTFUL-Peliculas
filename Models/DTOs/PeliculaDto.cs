﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ApiPeliculas.Models.Pelicula;

namespace ApiPeliculas.Models.DTOs
{
    public class PeliculaDto
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Ruta Imagen es obligatoria")]
        public string RutaImagen { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Duracion es obligatorio")]
        public string Duracion { get; set; }
        public TipoClasificacion Clasificacion { get; set; }

        //Relacion con tabla categoria
        public int categoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
