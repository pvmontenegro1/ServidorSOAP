using System;
using System.Collections.Generic;
using System.Web.Services;
namespace CRUDLibro
{
    public partial class LibroService : System.Web.Services.WebService
    {
        private static List<Libro> libros = new List<Libro>();

        [WebMethod]
        public string CrearLibro(string titulo, string autor, string isbn, int año)
        {
            int id = libros.Count + 1;
            var libro = new Libro { Id = id, Titulo = titulo, Autor = autor, ISBN = isbn, Año = año };
            libros.Add(libro);
            return $"Libro con ID {id} creado con éxito.";
        }

        [WebMethod]
        public List<Libro> LeerLibros()
        {
            return libros;
        }

        [WebMethod]
       
        public string ActualizarLibro(int id, string titulo, string autor, string isbn, int año)
        {
            var libro = libros.Find(l => l.Id == id); // Busca el libro por ID
            if (libro != null)
            {
                libro.Titulo = titulo;
                libro.Autor = autor;
                libro.ISBN = isbn;
                libro.Año = año;
                return "Libro actualizado con éxito.";
            }
            return "Libro no encontrado.";
        }


        [WebMethod]
        public string EliminarLibro(int id)
        {
            var libro = libros.Find(l => l.Id == id);
            if (libro != null)
            {
                libros.Remove(libro);
                return "Libro eliminado con éxito.";
            }
            return "Libro no encontrado.";
        }
    }
}