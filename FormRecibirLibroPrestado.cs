using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaExamenIngreso
{
    public partial class FormRecibirLibroPrestado : Form
    {
        Controlador controlador = new Controlador();
        public FormRecibirLibroPrestado()
        {
            InitializeComponent();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            controlador.VerificarDatosRecibirLibroPrestado(out string msj, txtISBNLibroDevuelto.Text, txtIDSocioDevuelve.Text);
            lblDesc.Text  = msj;
        }
    }
}
