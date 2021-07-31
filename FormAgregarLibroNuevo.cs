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
    public partial class FormAgregarLibroNuevo : Form
    {
        Controlador controlador = new Controlador();
        public FormAgregarLibroNuevo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreLibro == null || /*txtNumEdicion == null ||*/ txtAutor == null)
                return;
            controlador.VerificarDatosAgregarLibroABiblioteca(out string msj, txtISBN.Text, txtAutor.Text, txtNombreLibro.Text);
            lblFeedback.Text = msj;
        }
    }
}
