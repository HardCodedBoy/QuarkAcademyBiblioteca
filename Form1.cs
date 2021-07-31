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
    public partial class Form1 : Form
    {
        Controlador controlador = new Controlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarLibroNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarLibroNuevo agregarLibroNuevo = new FormAgregarLibroNuevo();
            agregarLibroNuevo.Show();
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormAgregarSocio agregarSocio = new FormAgregarSocio();
            agregarSocio.Show();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            FormPrestarLibro prestarLibro = new FormPrestarLibro();
            prestarLibro.Show();
        }

        private void btnRecibirLibroPrestado_Click(object sender, EventArgs e)
        {
            FormRecibirLibroPrestado recibirLibroPrestado = new FormRecibirLibroPrestado();
            recibirLibroPrestado.Show();
        }

        private void btnMostrarSocios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlador.MostrarSocios());
        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlador.MostrarLibros());
        }

        private void btnMostrarPrestaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlador.MostrarPrestaciones());
        }
    }
}
