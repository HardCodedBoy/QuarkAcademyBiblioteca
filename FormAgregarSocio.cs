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
    public partial class FormAgregarSocio : Form
    {
        Controlador controlador = new Controlador();
        public FormAgregarSocio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            controlador.AgreagrSocio(out string msj, txtNombre.Text, txtApellido.Text, rbtnVIP.Checked);
            lblDesc.Text = msj;
                
        }

        private void FormAgregarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
