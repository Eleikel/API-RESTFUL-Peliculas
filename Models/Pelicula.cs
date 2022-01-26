using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.Models
{
    public class Pelicula
    {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RutaImagen { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public enum TipoClasificacion { Siete, Trece, Dieciseis, Dieciocho }
        public  TipoClasificacion Clasificacion {get; set;}
        public DateTime FechaCreacion { get; set; }

        //Relacion con tabla categoria
        public int categoriaId { get; set; }

        [ForeignKey("categoriaId")]
        public Categoria Categoria { get; set; }

    }
}
