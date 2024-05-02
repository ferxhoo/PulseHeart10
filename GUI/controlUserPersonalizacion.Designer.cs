namespace GUI
{
    partial class controlUserPersonalizacion
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
            this.btnTemaClaro = new System.Windows.Forms.Button();
            this.btnTemaOscuro = new System.Windows.Forms.Button();
            this.btnTemaPredeterminado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxIconoRegistro = new System.Windows.Forms.PictureBox();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.btnTemaClaro);
            this.panelRegistro.Controls.Add(this.btnTemaOscuro);
            this.panelRegistro.Controls.Add(this.btnTemaPredeterminado);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Location = new System.Drawing.Point(3, 3);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(758, 583);
            this.panelRegistro.TabIndex = 4;
            // 
            // btnTemaClaro
            // 
            this.btnTemaClaro.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTemaClaro.Location = new System.Drawing.Point(321, 274);
            this.btnTemaClaro.Name = "btnTemaClaro";
            this.btnTemaClaro.Size = new System.Drawing.Size(130, 45);
            this.btnTemaClaro.TabIndex = 3;
            this.btnTemaClaro.Text = "Claro";
            this.btnTemaClaro.UseVisualStyleBackColor = false;
            this.btnTemaClaro.Click += new System.EventHandler(this.btnTemaClaro_Click);
            // 
            // btnTemaOscuro
            // 
            this.btnTemaOscuro.BackColor = System.Drawing.Color.DimGray;
            this.btnTemaOscuro.Location = new System.Drawing.Point(523, 274);
            this.btnTemaOscuro.Name = "btnTemaOscuro";
            this.btnTemaOscuro.Size = new System.Drawing.Size(130, 45);
            this.btnTemaOscuro.TabIndex = 2;
            this.btnTemaOscuro.Text = "Oscuro";
            this.btnTemaOscuro.UseVisualStyleBackColor = false;
            this.btnTemaOscuro.Click += new System.EventHandler(this.btnTemaOscuro_Click);
            // 
            // btnTemaPredeterminado
            // 
            this.btnTemaPredeterminado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTemaPredeterminado.Location = new System.Drawing.Point(124, 274);
            this.btnTemaPredeterminado.Name = "btnTemaPredeterminado";
            this.btnTemaPredeterminado.Size = new System.Drawing.Size(132, 45);
            this.btnTemaPredeterminado.TabIndex = 1;
            this.btnTemaPredeterminado.Text = "Predeterminado";
            this.btnTemaPredeterminado.UseVisualStyleBackColor = false;
            this.btnTemaPredeterminado.Click += new System.EventHandler(this.btnTemaPredeterminado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personalización";
            // 
            // pictureBoxIconoRegistro
            // 
            this.pictureBoxIconoRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIconoRegistro.Image = global::GUI.Properties.Resources.ImagenConfig;
            this.pictureBoxIconoRegistro.Location = new System.Drawing.Point(170, 20);
            this.pictureBoxIconoRegistro.Name = "pictureBoxIconoRegistro";
            this.pictureBoxIconoRegistro.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxIconoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconoRegistro.TabIndex = 8;
            this.pictureBoxIconoRegistro.TabStop = false;
            // 
            // controlUserPersonalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxIconoRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelRegistro);
            this.Name = "controlUserPersonalizacion";
            this.Size = new System.Drawing.Size(764, 589);
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxIconoRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemaClaro;
        private System.Windows.Forms.Button btnTemaOscuro;
        private System.Windows.Forms.Button btnTemaPredeterminado;
    }
}
