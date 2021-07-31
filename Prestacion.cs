using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class Prestacion
    {
        Ejemplar ejemplar;
        Socio socio;
        DateTime fechaPrestacion;

        public string MostrarData()
        {
            string str = "";
            str += socio.MostrarData();
            str += $"\nLibro: {ejemplar.Libro.Isbn} \nFecha Prestacion: {fechaPrestacion}";

            return str;
        }
        public Prestacion(Ejemplar _ejemplar, Socio _socio)
        {
            ejemplar = _ejemplar;
            socio = _socio;
            fechaPrestacion = DateTime.Now;
        }
    }
}
