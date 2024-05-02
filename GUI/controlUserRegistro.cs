using BLL;
using ENTITY;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class controlUserRegistro : UserControl
    {
        // Variable para almacenar el ID de la persona encontrada
        private string idPersonaEncontrada = "";

        ServicioPersona ServicioPersona = new ServicioPersona();
        public controlUserRegistro()
        {
            InitializeComponent();
            Config();
        }
        public void Config()
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.SelectedIndex = 0;
            txtPulsaciones.Enabled = false;
            btnEditar.Enabled = false;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            RestaurarlblAviso();
            lblCheck.Text = string.Empty;
            if (VerificarCamposVacio())
            {
                return;
            }
            else
            {
                Persona personaCreada = CrearPersona();
                string mensaje = ServicioPersona.AgregarPersona(personaCreada);
                MostrarMensaje(mensaje, personaCreada);
            }
        }

        private void MostrarMensaje(string mensaje, Persona personaCreada)
        {
            if(mensaje.Equals("La persona ya existe en el archivo."))
            {
                txtPulsaciones.Text = string.Empty;
                lblAvisoId.Text = mensaje;
            }
            else
            {
                txtPulsaciones.Text = personaCreada.Pulsacion.ToString();
                lblCheck.Text = mensaje;
            }
        }

        private Persona CrearPersona()
        {
            Persona persona = new Persona();
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            int edad = convertirEdadTextoEntero();
            string sexo = cmbSexo.SelectedItem.ToString();
            decimal pulsaciones = persona.CalcularPulsacion(sexo, edad); 
            return new Persona(id, nombre, edad, sexo, pulsaciones);
        }

        private int convertirEdadTextoEntero()
        {
            // Variable para almacenar la edad
            int edad;
            // Valida que el contenido del TextBox sea un número entero válido
            if (int.TryParse(txtEdad.Text, out edad))
            {
                // El contenido del TextBox es un número entero válido, puedes usar la variable "edad"
                return edad;
            }
            else
            {
                // El contenido del TextBox no es un número entero válido
                lblAvisoEdad.Text = "Ingrese una edad válida.";
                txtEdad.Focus(); // Devuelve el foco al TextBox para corregir la entrada
            }
            return edad;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla BackSpace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni la tecla BackSpace, ignora la tecla presionada
                e.Handled = true;
            }

        }
        public bool VerificarCamposVacio() 
        {
            bool control = false;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                control = true;
                lblAvisoId.Text = "El campo de Identificacion no puede ser vacio";
                return control;
            }
            else
            {
                if(string.IsNullOrEmpty(txtNombre.Text))
                {
                    control = true;
                    lblAvisoNombre.Text = "El campo de Nombre no puede ser vacio";
                    return control;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEdad.Text))
                    {
                        control = true;
                        lblAvisoEdad.Text = "El campo de Edad no puede ser vacio";
                        return control;
                    }
                }
            }
            return control;
        }
        public void RestaurarlblAviso()
        {
            lblAvisoId.Text = string.Empty;
            lblAvisoNombre.Text = string.Empty;
            lblAvisoEdad.Text= string.Empty;
        }
        public void RestaurarTextBox()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
        }
        void BotonesRestaurados(bool llave)
        {
            btnEditar.Enabled = !llave;
            btnGuardar.Enabled = llave;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RestaurarlblAviso();
            RestaurarTextBox();
            cmbSexo.SelectedIndex = 0;
            txtPulsaciones.Text = string.Empty;
            lblCheck.Text = string.Empty;
            BotonesRestaurados(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            string id = txtId.Text;
            if (string.IsNullOrEmpty(id))
            {
                lblAvisoId.Text = "Ingresa la identificacion de la persona que quieres buscar";
            }
            else
            {
                RestaurarlblAviso();
                Persona personaEncontrada = ServicioPersona.ConsultarPersona(id);
                if (personaEncontrada == null)
                {
                    lblAvisoId.Text = "No se encuentra registrada esta persona";
                }
                else
                {
                    idPersonaEncontrada = id; // Almacenamos el ID de la persona encontrada
                    MostrarInformacionPersonaEncontrada(personaEncontrada);
                    RestaurarlblAviso();
                    lblCheck.Text = string.Empty;
                    BotonesRestaurados(false);
                }
            }
        }
        private void MostrarInformacionPersonaEncontrada(Persona personaEncontrada)
        {
            txtNombre.Text = personaEncontrada.Nombre;
            int edad = personaEncontrada.Edad;
            txtEdad.Text = edad.ToString();

            string sexo = personaEncontrada.Sexo; // Supongamos que tienes esta variable con el valor "Masculino"
                                                  // Busca el índice del elemento que coincide con el valor de la variable sexo
            int indiceSeleccionado = cmbSexo.FindStringExact(sexo);
            // Si se encuentra un índice válido
            if (indiceSeleccionado != -1)
            {
                // Establece el índice del ComboBox para seleccionar el elemento
                cmbSexo.SelectedIndex = indiceSeleccionado;
            }
            decimal pulso = personaEncontrada.Pulsacion;
            txtPulsaciones.Text = pulso.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPersonaEncontrada))
            {
                lblAvisoId.Text = "Primero debes buscar una persona para editar.";
                return;
            }
            if (VerificarCamposVacio())
            {
                return;
            }
            else
            {
                RestaurarlblAviso();
                // Obtenemos la persona actualizada
                Persona personaEditada = CrearPersona();

                // Llamamos al método para actualizar la persona
                string mensaje = ServicioPersona.ActualizarPersona(idPersonaEncontrada, personaEditada);
                lblCheck.Text = mensaje;
            }
        }

    }
}
