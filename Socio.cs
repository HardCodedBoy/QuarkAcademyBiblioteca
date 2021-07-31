using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class Socio
    {
        private static int IdSocios = 0;
        string nombre;
        string apellido;
        int id;
        protected int cantMaxEjemplares;
        List<Ejemplar> ejemplaresRetirados = new List<Ejemplar>();

        public int Id { get => id; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }

        public bool TieneCupoDisponible()
        {
            if (ejemplaresRetirados.Count < cantMaxEjemplares)
                return true;
            return false;
        }


        public void RecibirEjemplar(Ejemplar e)
        {
                ejemplaresRetirados.Add(e);
        } 

        public Ejemplar DevolverEjemplar( long _isbn)
        {
            if (ejemplaresRetirados.Count > 0)
                foreach (var e in ejemplaresRetirados)
                    if (e.Libro.Isbn == _isbn)
                    {
                        Ejemplar ejemplar = e;
                        ejemplaresRetirados.Remove(ejemplar);
                        return ejemplar;
                    }

            return null;
        }


       public virtual string MostrarData()
        {
            string str = $"Nombre: {nombre} \nApellido: {apellido} \nID: {id} \nLibrosRetirados: {ejemplaresRetirados.Count}";
            return str;
        }

        public Socio(string _nombre, string _apellido)
        {
            id = IdSocios++;
            nombre = _nombre;
            apellido = _apellido;
            cantMaxEjemplares = 1;
        }
        //Ejemplar DevolverEjemplar(Ejemplar _ejemplar)
        //{
            
        //}

       
    }
}
