using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante oEstudiante1 = new Estudiante("Moises", 3, 4);
            Estudiante oEstudiante2 = new Estudiante("Navarro", 3, 4);
            Estudiante oEstudiante3 = new Estudiante("Cordero", 3, 4);

            List<Estudiante> lisEstudiante = new List<Estudiante>
            {
                oEstudiante1, oEstudiante2, oEstudiante3
            };

            Estudiante oEstudiante4 = new Estudiante("Alex", 3, 4);


            lisEstudiante.Add(oEstudiante4); //Metodo Add permite annadir elementos a una lista
            int cont = lisEstudiante.Count; //Metodo Cout permite contar los elmentos detro de una lista

            Console.WriteLine(cont);

            List<Estudiante> lista2 = new List<Estudiante>
            {
                new Estudiante("prueba", 3, 4)
            };

            lisEstudiante.AddRange(lista2); //Metodo AddRange nos permite annadir una lista 

            foreach (Estudiante estudiante in lisEstudiante)
            {
                Console.WriteLine(estudiante.Nombre);
            }

            
            Console.WriteLine(lisEstudiante[0].Nombre + " "+ lisEstudiante[2].Nombre);

            Console.ReadLine();
        }
    }
}
