using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    public class Libro
    {
        protected long isbn;
        protected string autor;
        protected string nombre;

        public long Isbn { get => isbn; }

        public Libro(long _isbn, string _autor, string _nombre)
        {
            isbn = _isbn;
            autor = _autor;
            nombre = _nombre;
        }
    }
}
