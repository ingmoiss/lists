using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Estudiante
    {
        private string nombre;
        private int nota1;
        private int nota2;

        public Estudiante(string nombre, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Nota1
        {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }

        public int Nota2
        {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }

    }
}
