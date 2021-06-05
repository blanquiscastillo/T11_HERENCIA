using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T11_EJERCICIO6
{
    class Program
    {
        class Libro
        {
            private string _ISBN;
            private string _titulo;
            private string _Autor;
            private int _numero_paginas;

            public string ISBN { get => _ISBN; set => _ISBN = value; }
            public string Titulo { get => _titulo; set => _titulo = value; }
            public string Autor { get => _Autor; set => _Autor = value; }
            public int Numero_paginas { get => _numero_paginas; set => _numero_paginas = value; }

            //Constructor
            public Libro(string iSBN,string titulo,string autor,int numero_paginas)
            {
                ISBN = iSBN;
                Titulo = titulo;
                Autor = autor;
                Numero_paginas = numero_paginas;
            }

            public override string ToString()
            {
                return "El libro " + Titulo + "  con ISBN" + ISBN  + " escrito por " + Autor +  " tiene " + Numero_paginas +  " paginas";
            }
        }
        static void Main(string[] args)
        {
            Libro libro = new Libro("445003022","El señor de los anillos", "John Ronald Reuel Tolkien", 100);
            Libro libro2 = new Libro("255003022", "Juego de Tronos", "George R. R. Martin", 300);
            Console.WriteLine("*** LIBROS ***");
            Console.WriteLine(libro);
            Console.WriteLine(libro2);
            Console.WriteLine("\n");

            if (libro.Numero_paginas > libro2.Numero_paginas)
                Console.WriteLine("El libro: " + libro.Titulo + "(" + libro.Numero_paginas + ") tiene mas paginas que el libro " + libro2.Titulo + "(" + libro2.Numero_paginas + ")");
            else
            if (libro.Numero_paginas < libro2.Numero_paginas)
                Console.WriteLine("El libro: " + libro2.Titulo + "(" + libro2.Numero_paginas + ") tiene mas paginas que el libro " + libro.Titulo + "(" + libro.Numero_paginas + ")");
            else
                Console.WriteLine("Los dos libros tienen la misma cantidad de paginas");

            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
        }

    }
}
