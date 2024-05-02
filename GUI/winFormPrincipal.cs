using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class winFormPrincipal : Form
    {
        public winFormPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }


        //

        // Manejador de eventos para el evento ColorChanged del control de usuario de personalización
        private void ControlUserPersonalizacion_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            // Cambia el color del MenuStrip al nuevo color seleccionado
            menuStripPrincipal.BackColor = e.NewColor;
        }

        //

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            controlUserRegistro controlUserRegistro = new controlUserRegistro
            {
                Dock = DockStyle.Fill
            };
            panelVista.Controls.Add(controlUserRegistro);
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            controlUserConsulta controlUserConsulta = new controlUserConsulta
            {
                Dock = DockStyle.Fill
            };
            panelVista.Controls.Add(controlUserConsulta);
        }

        private void personalizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Crea una instancia del control de usuario de personalización
            controlUserPersonalizacion controlUserPersonalizacion = new controlUserPersonalizacion();

            // Suscribe el manejador de eventos ColorChanged
            controlUserPersonalizacion.ColorChanged += ControlUserPersonalizacion_ColorChanged;

            // Agrega el control de usuario al panel
            panelVista.Controls.Clear();
            panelVista.Controls.Add(controlUserPersonalizacion);

        }
    }
}
