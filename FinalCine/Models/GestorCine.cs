using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalCine.Models
{
    public class GestorCine
    {
        public void Agregar(Pelicula nuevaPelicula)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS;Initial Catalog=cine;Persist Security Info=True;User ID=sa; Password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO Pelicula (nombrePelicula, descripcion, idTipo, calificacion, duracion) VALUES (@nombrePelicula, @descripcion, @idTipo, @calificacion, @duracion)", conn);

            comm.Parameters.Add(new SqlParameter("@nombrePelicula", nuevaPelicula.NombrePelicula));
            comm.Parameters.Add(new SqlParameter("@descripcion", nuevaPelicula.Descripcion));
            comm.Parameters.Add(new SqlParameter("@idTipo", nuevaPelicula.IdTipo));
            comm.Parameters.Add(new SqlParameter("@calificacion", nuevaPelicula.Calificacion));
            comm.Parameters.Add(new SqlParameter("@duracion", nuevaPelicula.Duracion));

            comm.ExecuteNonQuery();
            conn.Close();
        }

        public List<TipoPelicula>ObtenerNombres()
        {
            List<TipoPelicula> lista = new List<TipoPelicula>();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS;Initial Catalog=cine;Persist Security Info=True;User ID=sa; Password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM TipoPelicula", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while(dr.Read())
            {
                int idTipo = dr.GetInt32(0);
                string nombreTipo = dr.GetString(1);

                TipoPelicula TP = new TipoPelicula(idTipo, nombreTipo);
                lista.Add(TP);
            }
            conn.Close();
            return lista;
        }
        public List<PeliculaDto> Listar()
        {
            List<PeliculaDto> lista = new List<PeliculaDto>();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS;Initial Catalog=cine;Persist Security Info=True;User ID=sa; Password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT p.idPelicula, p.nombrePelicula, p.descripcion, t.nombreTipo, p.calificacion, p.duracion FROM Pelicula p INNER JOIN TipoPelicula t ON p.idTipo=t.idTipo", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int idPelicula = dr.GetInt32(0);
                string nombrePelicula = dr.GetString(1);
                string descripcion= dr.GetString(2);
                string nombreTipo= dr.GetString(3);
                int calificacion = dr.GetInt32(4);
                string duracion = dr.GetString(5);

                PeliculaDto P = new PeliculaDto(idPelicula, nombrePelicula, descripcion, nombreTipo, calificacion, duracion);
                lista.Add(P);
            }
            conn.Close();
            return lista;
        }

    }
}