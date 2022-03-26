using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCine.Models
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string Descripcion { get; set; }
        public int IdTipo { get; set; }
        public int Calificacion { get; set; }
        public string Duracion { get; set; }

        public Pelicula(int idPelicula, string nombrePelicula, string descripcion, int idTipo, int calificacion, string duracion)
        {
            IdPelicula = idPelicula;
            NombrePelicula = nombrePelicula;
            Descripcion = descripcion;
            IdTipo = idTipo;
            Calificacion = calificacion;
            Duracion = duracion;
        }
        public Pelicula() { }
    }
}