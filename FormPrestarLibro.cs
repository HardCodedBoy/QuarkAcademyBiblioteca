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
    public partial class FormPrestarLibro : Form
    {
        Controlador controlador = new Controlador();
        public FormPrestarLibro()
        {
            InitializeComponent();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            controlador.VerificarDatosPrestarLibro(out string msj, txtISBN.Text, txtIDSocio.Text);
            lblDesc.Text = msj;
        }
    }
}
