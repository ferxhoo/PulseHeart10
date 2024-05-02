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
    public partial class controlUserPersonalizacion : UserControl
    {

        public controlUserPersonalizacion()
        {
            InitializeComponent();
        }

        //
        // Evento para cambiar el color del MenuStrip
        public event EventHandler<ColorChangedEventArgs> ColorChanged;

        // Método para invocar el evento ColorChanged
        protected virtual void OnColorChanged(Color newColor)
        {
            ColorChanged?.Invoke(this, new ColorChangedEventArgs(newColor));
        }

        private void btnTemaClaro_Click(object sender, EventArgs e)
        {
            // Color específico que deseas enviar
            Color colorClaro = Color.SkyBlue; // Puedes cambiar esto al color que desees

            // Dispara el evento ColorChanged con el color específico
            OnColorChanged(colorClaro);
        }

        private void btnTemaPredeterminado_Click(object sender, EventArgs e)
        {
            // Color específico que deseas enviar
            Color colorPredeterminado = Color.WhiteSmoke; // Puedes cambiar esto al color que desees

            // Dispara el evento ColorChanged con el color específico
            OnColorChanged(colorPredeterminado);
        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            // Color específico que deseas enviar
            Color colorOscuro = Color.DimGray; // Puedes cambiar esto al color que desees

            // Dispara el evento ColorChanged con el color específico
            OnColorChanged(colorOscuro);
        }



        //

    }
}
