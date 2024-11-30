using System;
using ClienteLibroConsole.ServiceReference1;

namespace ClienteLibroConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del cliente del servicio SOAP
            var servicio = new LibroServiceSoapClient();

            // Menú de opciones
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Crear un libro");
            Console.WriteLine("2. Leer libros");
            Console.WriteLine("3. Actualizar un libro");
            Console.WriteLine("4. Eliminar un libro");
            Console.WriteLine("5. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Crear un libro
                    CrearLibro(servicio);
                    break;
                case 2:
                    // Leer todos los libros
                    LeerLibros(servicio);
                    break;
                case 3:
                    // Actualizar un libro
                    ActualizarLibro(servicio);
                    break;
                case 4:
                    // Eliminar un libro
                    EliminarLibro(servicio);
                    break;
                case 5:
                    // Salir
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            // Esperar para cerrar la consola
            Console.ReadLine();
        }

        // Método para crear un libro
        static void CrearLibro(LibroServiceSoapClient servicio)
        {
            Console.WriteLine("Ingrese el título del libro:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro:");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese el ISBN del libro:");
            string isbn = Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicación:");
            int año = int.Parse(Console.ReadLine());

            // Llamar al método CrearLibro del servicio SOAP
            string resultado = servicio.CrearLibro(titulo, autor, isbn, año);
            Console.WriteLine(resultado);
        }

        // Método para leer todos los libros
        static void LeerLibros(LibroServiceSoapClient servicio)
        {
            // Llamar al método LeerLibros del servicio SOAP
            var libros = servicio.LeerLibros();
            Console.WriteLine("Lista de libros:");
            foreach (var libro in libros)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Año: {libro.Año}");
            }
        }

        // Método para actualizar un libro
        static void ActualizarLibro(LibroServiceSoapClient servicio)
        {
            Console.WriteLine("Ingrese el ID del libro a actualizar:");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Ingrese el nuevo título del libro:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo autor del libro:");
                string autor = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo ISBN del libro:");
                string isbn = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo año de publicación:");
                int año = int.Parse(Console.ReadLine());

                // Llamar al método ActualizarLibro del servicio SOAP con el ID
                string resultado = servicio.ActualizarLibro(id, titulo, autor, isbn, año);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("ID inválido. Por favor ingrese un número.");
            }
        }


        // Método para eliminar un libro
        static void EliminarLibro(LibroServiceSoapClient servicio)
        {
            Console.WriteLine("Ingrese el ID del libro a eliminar:");

            // Convierte el valor leído en Console.ReadLine() a int.
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                // Llamar al método EliminarLibro del servicio SOAP
                string resultado = servicio.EliminarLibro(id);

                // Mostrar el mensaje de resultado
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("ID inválido. Por favor ingrese un número.");
            }
        }

    }
}
