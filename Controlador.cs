using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class Controlador
    {
        private static Biblioteca biblioteca = new Biblioteca();
        private bool VerificarTipoDeDato(string tipo, string dato)
        {
            switch (tipo)
            {
                case "int":
                    try { Convert.ToInt32(dato); return true; }
                    catch { return false; }
                case "double":
                    try { Convert.ToDouble(dato); return true; }
                    catch { return false; }
                case "long":
                    try { Convert.ToInt64(dato); return true; }
                    catch { return false; }
                default:
                    return false;
            }
        }

        public void VerificarDatosAgregarLibroABiblioteca(out string mensajeExcepcion, string _isbn, string _autor, string _nombre )
        {
            if (VerificarIsbn(_isbn) == false)
            {
                mensajeExcepcion = "isbn introducido incorrecto";
                return;
            }
            if(VerificarTipoDeDato("long", _isbn))
            {
                long isbn = Convert.ToInt64(_isbn);
                biblioteca.AgregarLibroBiblioteca(isbn, _autor, _nombre);
                mensajeExcepcion = "Libro agregado con exito";
            } else
            {
                mensajeExcepcion = "Datos erroneos";
            }
        }

        public void VerificarDatosPrestarLibro(out string msj,string _isbn, string _idSocio)
        {
            if (VerificarIsbn(_isbn) == false)
            {
                msj = "isbn introducido incorrecto";
                return;
            }
            if (VerificarTipoDeDato("long", _isbn) && VerificarTipoDeDato("int", _idSocio))
            {
                long isbn = Convert.ToInt64(_isbn);
                int id = Convert.ToInt32(_idSocio);
                biblioteca.AsignarEjemplarASocio(out msj, isbn, id);
            }
            else
            {
                msj = "Datos incorrectos";
            }
        }

        public void VerificarDatosRecibirLibroPrestado(out string msj, string _isbn, string _socioId)
        {
            if (VerificarIsbn(_isbn) == false)
            {
                msj = "isbn introducido incorrecto";
                return;
            }
            msj = "Datos incorrectos";
            if(VerificarTipoDeDato("long", _isbn) && VerificarTipoDeDato("int", _socioId))
            {
                long isbn = Convert.ToInt64(_isbn);
                int id = Convert.ToInt32(_socioId);
                biblioteca.RecibirEjemplarDeSocio(out msj, isbn, id);
            }
        }

        public void AgreagrSocio(out string msj, string _nombre, string _apellido, bool _esVip)
        {
            msj = "Socio Agregado Con Exito";
            biblioteca.AgregarSocio(_nombre, _apellido, _esVip);
        }

        public string MostrarSocios()
        {
            string str = "";
            foreach (var s in biblioteca.Socios.Values)
            {
                str += s.MostrarData() + "\n ------------ \n \n";
            }

            return str;
        }

        public string MostrarLibros()
        {
            string str = "";
            foreach (var l in biblioteca.Libros.Values)
            {
                str += l.MostrarData() + "\n ------------ \n \n";
            }
            return str;
        }

        public string MostrarPrestaciones()
        {
            string str = "";
            foreach (var p in biblioteca.Prestaciones)
            {
                str += p.MostrarData() + "\n ------------ \n \n";
            }

            return str;
        }

        private bool VerificarIsbn(string _isbn)
        {
            bool resultado = false;
            if (!string.IsNullOrEmpty(_isbn))
            {
                long n;
                if (_isbn.Contains('-'))
                    _isbn = _isbn.Replace("-", "");
                if (!Int64.TryParse(_isbn, out n))
                    resultado = false;
                int suma = 0;
                for (int i = 0; i < 12; i++)
                {
                    suma += Int32.Parse(_isbn[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }
                int resto = suma % 10;
                int checkDigit = 10 - resto;
                if (checkDigit == 10) checkDigit = 0;
                resultado = (checkDigit == int.Parse(_isbn[12].ToString()));
            }
            return resultado;
        }
    } 
}
