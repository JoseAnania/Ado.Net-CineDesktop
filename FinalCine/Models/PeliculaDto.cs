using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCine.Models
{
    public class PeliculaDto
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string Descripcion { get; set; }
        public string NombreTipo { get; set; }
        public int Calificacion { get; set; }
        public string Duracion { get; set; }

        public PeliculaDto(int idPelicula, string nombrePelicula, string descripcion, string nombreTipo, int calificacion, string duracion)
        {
            IdPelicula = idPelicula;
            NombrePelicula = nombrePelicula;
            Descripcion = descripcion;
            NombreTipo = nombreTipo;
            Calificacion = calificacion;
            Duracion = duracion;
        }
        public PeliculaDto() { }
    }
}