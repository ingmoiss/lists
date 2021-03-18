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

            Console.WriteLine(lisEstudiante[0].Nombre + " "+ lisEstudiante[2].Nombre);

            Console.ReadLine();
        }
    }
}
