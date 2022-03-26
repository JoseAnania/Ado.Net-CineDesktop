using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCine.Models
{
    public class Cine
    {
        public Pelicula pelicula { get; set; }
        public List<TipoPelicula> nombrePelicula { get; set; }
    }
}