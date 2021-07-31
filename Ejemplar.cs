using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class Ejemplar
    {
        Libro libro;
        int numEdicion;
        int numEstanteria;
        static int NumerosDeEdicion = 0;

        public Libro Libro { get => libro; }
        public int NumEdicion { get => numEdicion; }
        public int NumEstanteria { get => numEstanteria; }
        public Ejemplar(Libro l, int _numEstanteria)
        {
            libro = l;
            numEstanteria = _numEstanteria;
            numEdicion = NumerosDeEdicion++;
        }
    }
}
