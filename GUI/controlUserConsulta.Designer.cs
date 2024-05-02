namespace GUI
{
    partial class controlUserConsulta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.lblAvisoDelete = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulsacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxIconoRegistro = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.lblAvisoDelete);
            this.panelRegistro.Controls.Add(this.btnEliminar);
            this.panelRegistro.Controls.Add(this.dataGridViewPersona);
            this.panelRegistro.Controls.Add(this.pictureBoxIconoRegistro);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Location = new System.Drawing.Point(3, 3);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(758, 583);
            this.panelRegistro.TabIndex = 4;
            // 
            // lblAvisoDelete
            // 
            this.lblAvisoDelete.AutoSize = true;
            this.lblAvisoDelete.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoDelete.Location = new System.Drawing.Point(249, 538);
            this.lblAvisoDelete.Name = "lblAvisoDelete";
            this.lblAvisoDelete.Size = new System.Drawing.Size(0, 16);
            this.lblAvisoDelete.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(50, 524);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 45);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.AllowUserToOrderColumns = true;
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Edad,
            this.Sexo,
            this.Pulsacion});
            this.dataGridViewPersona.Location = new System.Drawing.Point(50, 96);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.ReadOnly = true;
            this.dataGridViewPersona.RowHeadersWidth = 49;
            this.dataGridViewPersona.RowTemplate.Height = 24;
            this.dataGridViewPersona.Size = new System.Drawing.Size(670, 420);
            this.dataGridViewPersona.TabIndex = 7;
            this.dataGridViewPersona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersona_CellClick);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Pulsacion
            // 
            this.Pulsacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pulsacion.HeaderText = "Pulsaciones";
            this.Pulsacion.MinimumWidth = 6;
            this.Pulsacion.Name = "Pulsacion";
            this.Pulsacion.ReadOnly = true;
            // 
            // pictureBoxIconoRegistro
            // 
            this.pictureBoxIconoRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIconoRegistro.Image = global::GUI.Properties.Resources.ImagenConsulta;
            this.pictureBoxIconoRegistro.Location = new System.Drawing.Point(170, 20);
            this.pictureBoxIconoRegistro.Name = "pictureBoxIconoRegistro";
            this.pictureBoxIconoRegistro.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxIconoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconoRegistro.TabIndex = 6;
            this.pictureBoxIconoRegistro.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "LISTADO DE PERSONAS";
            // 
            // controlUserConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRegistro);
            this.Name = "controlUserConsulta";
            this.Size = new System.Drawing.Size(763, 589);
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.PictureBox pictureBoxIconoRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.Label lblAvisoDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulsacion;
    }
}
