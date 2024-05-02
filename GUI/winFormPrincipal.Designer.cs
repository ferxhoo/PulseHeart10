namespace GUI
{
    partial class winFormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winFormPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelVista = new System.Windows.Forms.Panel();
            this.pictureBoxMarcaDeAgua = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            this.panelVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarcaDeAgua)).BeginInit();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelVista);
            this.panelPrincipal.Controls.Add(this.menuStripPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(5, 5);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(773, 646);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelVista
            // 
            this.panelVista.BackColor = System.Drawing.Color.White;
            this.panelVista.Controls.Add(this.pictureBoxMarcaDeAgua);
            this.panelVista.Location = new System.Drawing.Point(7, 31);
            this.panelVista.Name = "panelVista";
            this.panelVista.Size = new System.Drawing.Size(758, 583);
            this.panelVista.TabIndex = 2;
            // 
            // pictureBoxMarcaDeAgua
            // 
            this.pictureBoxMarcaDeAgua.Image = global::GUI.Properties.Resources.ImagenFondoPantallaPH10;
            this.pictureBoxMarcaDeAgua.Location = new System.Drawing.Point(139, 52);
            this.pictureBoxMarcaDeAgua.Name = "pictureBoxMarcaDeAgua";
            this.pictureBoxMarcaDeAgua.Size = new System.Drawing.Size(480, 480);
            this.pictureBoxMarcaDeAgua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarcaDeAgua.TabIndex = 0;
            this.pictureBoxMarcaDeAgua.TabStop = false;
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.personalizaciónToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(773, 28);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // personalizaciónToolStripMenuItem
            // 
            this.personalizaciónToolStripMenuItem.Name = "personalizaciónToolStripMenuItem";
            this.personalizaciónToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.personalizaciónToolStripMenuItem.Text = "Personalización";
            this.personalizaciónToolStripMenuItem.Click += new System.EventHandler(this.personalizaciónToolStripMenuItem_Click);
            // 
            // winFormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "winFormPrincipal";
            this.Text = "PulseHeart10";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarcaDeAgua)).EndInit();
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizaciónToolStripMenuItem;
        private System.Windows.Forms.Panel panelVista;
        private System.Windows.Forms.PictureBox pictureBoxMarcaDeAgua;
    }
}

