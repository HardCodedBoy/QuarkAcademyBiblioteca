
namespace BibliotecaExamenIngreso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarLibroNuevo = new System.Windows.Forms.Button();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.btnRecibirLibroPrestado = new System.Windows.Forms.Button();
            this.btnMostrarSocios = new System.Windows.Forms.Button();
            this.btnMostrarLibros = new System.Windows.Forms.Button();
            this.btnMostrarPrestaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarLibroNuevo
            // 
            this.btnAgregarLibroNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibroNuevo.Location = new System.Drawing.Point(12, 59);
            this.btnAgregarLibroNuevo.Name = "btnAgregarLibroNuevo";
            this.btnAgregarLibroNuevo.Size = new System.Drawing.Size(226, 104);
            this.btnAgregarLibroNuevo.TabIndex = 1;
            this.btnAgregarLibroNuevo.Text = "Agregar Libro Nuevo";
            this.btnAgregarLibroNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarLibroNuevo.Click += new System.EventHandler(this.btnAgregarLibroNuevo_Click);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestarLibro.Location = new System.Drawing.Point(12, 183);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(226, 97);
            this.btnPrestarLibro.TabIndex = 2;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = true;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSocio.Location = new System.Drawing.Point(12, 302);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(226, 97);
            this.btnAgregarSocio.TabIndex = 3;
            this.btnAgregarSocio.Text = "Agregar Socio";
            this.btnAgregarSocio.UseVisualStyleBackColor = true;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            // 
            // btnRecibirLibroPrestado
            // 
            this.btnRecibirLibroPrestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibirLibroPrestado.Location = new System.Drawing.Point(12, 426);
            this.btnRecibirLibroPrestado.Name = "btnRecibirLibroPrestado";
            this.btnRecibirLibroPrestado.Size = new System.Drawing.Size(226, 97);
            this.btnRecibirLibroPrestado.TabIndex = 4;
            this.btnRecibirLibroPrestado.Text = "Recibir Libro Prestado";
            this.btnRecibirLibroPrestado.UseVisualStyleBackColor = true;
            this.btnRecibirLibroPrestado.Click += new System.EventHandler(this.btnRecibirLibroPrestado_Click);
            // 
            // btnMostrarSocios
            // 
            this.btnMostrarSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSocios.Location = new System.Drawing.Point(347, 133);
            this.btnMostrarSocios.Name = "btnMostrarSocios";
            this.btnMostrarSocios.Size = new System.Drawing.Size(166, 97);
            this.btnMostrarSocios.TabIndex = 5;
            this.btnMostrarSocios.Text = "MostrarSocios";
            this.btnMostrarSocios.UseVisualStyleBackColor = true;
            this.btnMostrarSocios.Click += new System.EventHandler(this.btnMostrarSocios_Click);
            // 
            // btnMostrarLibros
            // 
            this.btnMostrarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLibros.Location = new System.Drawing.Point(347, 247);
            this.btnMostrarLibros.Name = "btnMostrarLibros";
            this.btnMostrarLibros.Size = new System.Drawing.Size(166, 97);
            this.btnMostrarLibros.TabIndex = 6;
            this.btnMostrarLibros.Text = "Mostrar Libros";
            this.btnMostrarLibros.UseVisualStyleBackColor = true;
            this.btnMostrarLibros.Click += new System.EventHandler(this.btnMostrarLibros_Click);
            // 
            // btnMostrarPrestaciones
            // 
            this.btnMostrarPrestaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPrestaciones.Location = new System.Drawing.Point(347, 367);
            this.btnMostrarPrestaciones.Name = "btnMostrarPrestaciones";
            this.btnMostrarPrestaciones.Size = new System.Drawing.Size(166, 84);
            this.btnMostrarPrestaciones.TabIndex = 7;
            this.btnMostrarPrestaciones.Text = "Mostrar Prestaciones";
            this.btnMostrarPrestaciones.UseVisualStyleBackColor = true;
            this.btnMostrarPrestaciones.Click += new System.EventHandler(this.btnMostrarPrestaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 595);
            this.Controls.Add(this.btnMostrarPrestaciones);
            this.Controls.Add(this.btnMostrarLibros);
            this.Controls.Add(this.btnMostrarSocios);
            this.Controls.Add(this.btnRecibirLibroPrestado);
            this.Controls.Add(this.btnAgregarSocio);
            this.Controls.Add(this.btnPrestarLibro);
            this.Controls.Add(this.btnAgregarLibroNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLibroNuevo;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Button btnRecibirLibroPrestado;
        private System.Windows.Forms.Button btnMostrarSocios;
        private System.Windows.Forms.Button btnMostrarLibros;
        private System.Windows.Forms.Button btnMostrarPrestaciones;
    }
}

