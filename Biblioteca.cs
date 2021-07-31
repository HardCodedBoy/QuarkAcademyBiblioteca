using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class Biblioteca
    {
        Dictionary<long, LibroBiblioteca> libros = new Dictionary<long, LibroBiblioteca>();
        Dictionary<int, Socio> socios = new Dictionary<int, Socio>();
        List<Prestacion> prestaciones = new List<Prestacion>();
        bool[] estanteriasDisponibles = new bool[1000]; 
        public Dictionary<long, LibroBiblioteca> Libros { get => libros; }
        public Dictionary<int, Socio> Socios { get => socios; }
        public List<Prestacion> Prestaciones { get => prestaciones; } 


        public void AgregarLibroBiblioteca(long _isbn, string _autor, string _nombre)
        {
            if (libros.ContainsKey(_isbn))
            {
                Libro newLibro = new Libro(_isbn, _autor, _nombre);
                Ejemplar newEjemplar = new Ejemplar(newLibro, ObtenerEstanteriaLibre());
                libros[_isbn].AgregarEjemplar(newEjemplar);
            }
            else
            {
                LibroBiblioteca newLibroBiblioteca = new LibroBiblioteca(_isbn, _autor, _nombre, ObtenerEstanteriaLibre());
                libros.Add(_isbn, newLibroBiblioteca);
            }
        }

        public void AsignarEjemplarASocio(out string msj, long _isbn, int _idSocio)
        {
            msj = "Error";
            Ejemplar e = PrestarLibro(_isbn);
            if(e != null)
            {
                if (socios.ContainsKey(_idSocio))
                {
                    if(socios[_idSocio].TieneCupoDisponible() == false)
                    {
                        msj = "El Socio no tiene cupo para retirar libro";
                        return;
                    }
                    socios[_idSocio].RecibirEjemplar(e);
                    prestaciones.Add(new Prestacion (e, socios[_idSocio]));
                    msj = "Ejemplar asignado con éxito";
                }
            }
            else
            {
                msj = "Ejemplar no encontrado";
            }
        }

        public void RecibirEjemplarDeSocio(out string msj, long _isbn, int _socioId)
        {
            msj = "El socio no posee un ejemplar con ese isbn";
            if (socios.ContainsKey(_socioId))
            {
                Ejemplar e = socios[_socioId].DevolverEjemplar(_isbn);
                if(e != null)
                {
                    libros[_isbn].AgregarEjemplar(e);
                    msj = "Libro recibido con éxito";
                }
            }
        }

        public void AgregarSocio(string _nombre, string _apellido, bool _esVip)
        {
            if(_esVip)
            {
                SocioVIP newSocio = new SocioVIP(_nombre, _apellido);
                socios.Add(newSocio.Id, newSocio);
            }
            else
            {
                Socio newSocio = new Socio(_nombre, _apellido);
                socios.Add(newSocio.Id, newSocio);
            }
        }

        public int ObtenerEstanteriaLibre()
        {
            int n = -1;
            for (int i = 0; i < estanteriasDisponibles.Length; i++)
                if (estanteriasDisponibles[i] == true)
                    return i;
            return n;
        }

        private Ejemplar PrestarLibro(long _isbn)
        {
            if (libros.ContainsKey(_isbn))
                return libros[_isbn].PrestarEjemplar();

            return null;
        }



        public Biblioteca()
        {
            for (int i = 0; i < estanteriasDisponibles.Length; i++)
                estanteriasDisponibles[i] = true;

            libros.Add(9788477651147, new LibroBiblioteca(9788477651147, "Juan Rulfo", "El gallo de oro", ObtenerEstanteriaLibre()));
            libros.Add(9789878354040, new LibroBiblioteca(9789878354040, "Bram Stoker", "Drácula", ObtenerEstanteriaLibre()));
            libros.Add(9788477651149, new LibroBiblioteca(9788477651149, "José Saramago", "El evangelio según Jesucristo", ObtenerEstanteriaLibre()));

            Socio s1 = new Socio("Bruno", "Riba");
            Socio s2 = new Socio("Pedro", "Perez");
            Socio s3 = new Socio("Maria", "Vi");
            socios.Add( s1.Id,s1);
            socios.Add(s2.Id, s2);
            socios.Add(s3.Id, s3);
        }
    }
}
