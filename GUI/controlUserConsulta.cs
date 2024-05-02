using BLL;
using ENTITY;
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
    public partial class controlUserConsulta : UserControl
    {
        
        public controlUserConsulta()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarListaPersonas();
        }
        // Obtener la lista de personas
        ServicioPersona servicioPersona = new ServicioPersona();
        List<Persona> listaPersonas;
        // Declaración de la variable para almacenar el número de la celda seleccionada
        private int numeroCeldaSeleccionada = -1;

        private void ConfigurarDataGridView()
        {
            // Establecer el modo de ajuste de tamaño de las columnas
            dataGridViewPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void MostrarListaPersonas()
        {
            // Obtener la lista de personas utilizando el método ObtenerLista del ServicioPersona
            listaPersonas = servicioPersona.ObtenerListaPersona();

            // Limpiar las filas existentes en el DataGridView
            dataGridViewPersona.Rows.Clear();

            // Recorrer la lista de personas y agregarlas al DataGridView
            foreach (var persona in listaPersonas)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dataGridViewPersona.Rows.Add();

                // Asignar los valores de las propiedades de la persona a las celdas correspondientes
                dataGridViewPersona.Rows[rowIndex].Cells["Identificacion"].Value = persona.Identificacion;
                dataGridViewPersona.Rows[rowIndex].Cells["Nombre"].Value = persona.Nombre;
                dataGridViewPersona.Rows[rowIndex].Cells["Edad"].Value = persona.Edad;
                dataGridViewPersona.Rows[rowIndex].Cells["Sexo"].Value = persona.Sexo;
                dataGridViewPersona.Rows[rowIndex].Cells["Pulsacion"].Value = persona.Pulsacion;
            }
        }

        private void dataGridViewPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAvisoDelete.Text = string.Empty;
            // Verificar si la celda seleccionada es válida y no es la cabecera de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Seleccionar toda la fila en lugar de solo la celda
                dataGridViewPersona.Rows[e.RowIndex].Selected = true;

                // Actualizar el número de la celda seleccionada
                numeroCeldaSeleccionada = e.RowIndex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numeroCeldaSeleccionada != -1)
            {
                try
                {
                    // Obtener la identificación de la persona seleccionada
                    string id = (string)this.dataGridViewPersona.SelectedRows[0].Cells[0].Value;

                    // Mostrar un cuadro de diálogo de confirmación
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificar la opción seleccionada por el usuario
                    if (resultado == DialogResult.Yes)
                    {
                        // El usuario ha confirmado la eliminación, proceder con la eliminación del elemento
                        EliminarPersona(id);
                    }
                }
                catch (Exception)
                {
                    return;
                }

            }
            else
            {
                lblAvisoDelete.Text = "No has seleccionado ningún elemento para eliminar.";
            }
        }

        private void EliminarPersona(string id)
        {
            // Llamar al método para eliminar la persona utilizando el servicio o la lógica correspondiente
            string mensaje = servicioPersona.EliminarPersona(id);

            // Mostrar mensaje de resultado
            lblAvisoDelete.Text = mensaje;
            // Actualizar la lista de personas mostrada en el DataGridView
            MostrarListaPersonas();
        }
    }
}
