using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCine.Models
{
    public class TipoPelicula
    {
        public int IdTipo { get; set; }
        public string NombreTipo { get; set; }

        public TipoPelicula(int idTipo, string nombreTipo)
        {
            IdTipo = idTipo;
            NombreTipo = nombreTipo;
        }
        public TipoPelicula() { }
    }
}