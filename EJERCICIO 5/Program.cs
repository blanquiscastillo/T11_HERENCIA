using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace T11_EJERCICIO5
{
    class Program
    {

        public interface Entregable
        {
            void entregar();
            void devolver();

            bool isEntregado();
        }

        public class Serie:Entregable
        {
            private String _titulo;
            private int _no_temporadas;
            private bool _entregado;
            private string _genero;
            private string _creador;

            public string Titulo { get => _titulo; set => _titulo = value; }
            public int No_temporadas { get => _no_temporadas; set => _no_temporadas = value; }
            public bool Entregado { get => _entregado; set => _entregado = value; }
            public string Genero { get => _genero; set => _genero = value; }
            public string Creador { get => _creador; set => _creador = value; }

            //constructor por defecto
            public Serie()
            {
                Titulo = "";
                No_temporadas = 3;
                Entregado = false;
                Genero = "";
                Creador = "";

            }

            //contructor por titulo y creador
            public Serie(string titulo,string creador)
            {
                Titulo = titulo;
                No_temporadas = 3;
                Entregado = false;
                Genero = "";
                Creador = creador;
            }

            //constructor con todos los atributos excepto entregado
            public Serie(string titulo, int no_temporadas,string genero,string creador)
            {
                Titulo = titulo;
                No_temporadas = no_temporadas;
                Entregado = false;
                Genero = genero;
                Creador = creador;
            }
            public override string ToString()
            {
                return "Titulo: (" + Titulo + ") No temporadas: (" + No_temporadas + ") Entregado: (" + Entregado + ") Genero: (" + Genero + ") Creador:  (" + Creador + ")";
            }


            public void entregar()
            {
                this.Entregado = true;
            }

            public void devolver()
            {
                this.Entregado = false;
            }

            public bool isEntregado()
            {
                return this.Entregado;
            }
        }// Clase serie
        class Videojuego:Entregable
        {
            private string _titulo;
            private int _horas_estimadas;
            private bool _entregado;
            private string _genero;
            private string _compañia;

            public string Titulo { get => _titulo; set => _titulo = value; }
            public int Horas_estimadas { get => _horas_estimadas; set => _horas_estimadas = value; }
            public bool Entregado { get => _entregado; set => _entregado = value; }
            public string Genero { get => _genero; set => _genero = value; }
            public string Compañia { get => _compañia; set => _compañia = value; }

            
            //Constructor por defecto
            public Videojuego()
            {
                Titulo = "";
                Horas_estimadas = 10;
                Entregado = false;
                Genero = "";
                Compañia = "";
            }

            //Constructor por titulo, horas estimadas y el resto por defecto
            public Videojuego(string titulo, int horas_estimadas)
            {
                Titulo = titulo;
                Horas_estimadas = horas_estimadas;
                Entregado = false;
                Genero = "";
                Compañia = "";
            }

            //Constructor con todos los atributos excepto de entregado
            public Videojuego(string titulo, int horas_estimadas,string genero,string compañia)
            {
                Titulo = titulo;
                Horas_estimadas = horas_estimadas;
                Entregado = false;
                Genero = genero;
                Compañia = compañia;
            }

            public override string ToString()
            {
                return "Titulo: (" + Titulo + ") Horas estimadas: (" + Horas_estimadas + ") Entregado: (" + Entregado + ") Genero: (" + Genero + " ) Compañia: (" + Compañia + ")";
            }


            public void entregar()
            {
                this.Entregado = true;
            }

            public void devolver()
            {
                this.Entregado = false;
            }

            public bool isEntregado()
            {
                return Entregado;
            }


        }//Clase videojuego



        static void Main(string[] args)
        {
            //Crear dos arreglos de 5 posiciones uno de series y otro de videojuegos
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            //Crear un objeto en cada posicion de los arreglos

            series[0] = new Serie("Serie 0","Creador 0");
            series[1] = new Serie("Karate kid","creador x");
            series[2] = new Serie("Juegos de tronos", 7,"drama","creador y");
            series[3] = new Serie();
            series[4] = new Serie("Serie de moda",10,"comedia","creador de moda");
            
            videojuegos[0] = new Videojuego("Videojuego cero",5,"Infantil","compañia x");
            videojuegos[1] = new Videojuego();
            videojuegos[2] = new Videojuego("Videojuego dos",10);
            videojuegos[3] = new Videojuego();
            videojuegos[4] = new Videojuego("Videojuego cuatro", 20,"infantil","disney");

            series[1].entregar();
            series[1].entregar();
            series[1].devolver();
            series[4].entregar();
            series[0].entregar();

            videojuegos[0].entregar();
            videojuegos[3].entregar();
            videojuegos[4].entregar();
            videojuegos[0].devolver();

      
            //Contando cuantas series hay entregadas
            int contador_series = 0;
            int contador_videojuegos = 0;
            int max_horas = 0;
            int max_temporadas = 0;
            int serie_max = 0;
            int video_max = 0;


            Console.WriteLine("** SERIES ENTREGADAS **");
            
            for (int i = 0; i < 5; i++)
            {
                if (series[i].isEntregado())
                {
                    contador_series++;
                    Console.WriteLine("SERIE " + i);
                    Console.WriteLine(series[i]);
                }                
  
                if (series[i].No_temporadas > max_temporadas)
                {                     
                    max_temporadas = series[i].No_temporadas;
                    serie_max = i;
                }                
            }
            
            Console.WriteLine("Cantidad de series entregadas: " + contador_series);
            Console.WriteLine("\n");
            Console.WriteLine("Serie con mas temporadas:");
            Console.WriteLine("SERIE " + serie_max);
            Console.WriteLine(series[serie_max]);
            Console.WriteLine("\n");

            Console.WriteLine("** VIDEOJUEGOS ENTREGADAS **");           

            for (int i = 0; i < 5; i++)
            {
                if (videojuegos[i].isEntregado())
                {
                    contador_videojuegos++;
                    Console.WriteLine("VIDEOJUEGO " + i);
                    Console.WriteLine(videojuegos[i]);

                }
                if (videojuegos[i].Horas_estimadas > max_temporadas)
                {
                    max_horas = videojuegos[i].Horas_estimadas;
                    video_max = i;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de videojuegos entregados: " + contador_videojuegos);
            Console.WriteLine("\n");
            Console.WriteLine("VideoJuego con mas horas:");
            Console.WriteLine("VIDEOJUEGO " + video_max);
            Console.WriteLine(videojuegos[video_max]);





            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
