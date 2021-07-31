using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class LibroBiblioteca : Libro
    {
        Queue<Ejemplar> ejemplares;

        private bool ConsultarDisponibilidadEjemplares()
        {
            return ejemplares.Count > 0;
        }

        public Ejemplar PrestarEjemplar()
        {
            if (ConsultarDisponibilidadEjemplares())
                return ejemplares.Dequeue();
            else
                return null;
        }

        public void AgregarEjemplar(Ejemplar e)
        {
            ejemplares.Enqueue(e);
        }

        public string MostrarData()
        {
            string str = $"Nombre: {nombre} \nISBN: {isbn}\nAutor: {autor} \nEjemplares disponibles: {ejemplares.Count}";
            return str;
        }

        public LibroBiblioteca(long _isbn, string _autor, string _nombre, int _estanteria) : base(_isbn, _autor, _nombre)
        {
            ejemplares = new Queue<Ejemplar>();
            AgregarEjemplar(new Ejemplar(this, _estanteria));
        }
    }
}
