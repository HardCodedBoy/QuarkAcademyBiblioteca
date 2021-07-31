using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExamenIngreso
{
    class SocioVIP : Socio  
    {
        double cuotaMensual = 200;

        public override string MostrarData()
        {
            string str= base.MostrarData();
            str += $"\nVIP";
            return str;
        }
        public SocioVIP(string _nombre, string _apellido) : base (_nombre, _apellido)
        {
            cantMaxEjemplares = 3;
        }
        
    }
}
