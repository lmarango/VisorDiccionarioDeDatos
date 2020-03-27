namespace Con_DiccDeDatos
{
    partial class FormSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSesion));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIniSesion = new System.Windows.Forms.Button();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.lblSelConsulta = new System.Windows.Forms.Label();
            this.cbSelOpc2 = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblSel2 = new System.Windows.Forms.Label();
            this.lblSel3 = new System.Windows.Forms.Label();
            this.cbSelOpc3 = new System.Windows.Forms.ComboBox();
            this.lblIntroduc = new System.Windows.Forms.Label();
            this.lblSelOpc3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 144);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(12, 183);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(104, 19);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "INICIAR SESIÓN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 144);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(124, 184);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(131, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // btnIniSesion
            // 
            this.btnIniSesion.Location = new System.Drawing.Point(146, 220);
            this.btnIniSesion.Name = "btnIniSesion";
            this.btnIniSesion.Size = new System.Drawing.Size(90, 23);
            this.btnIniSesion.TabIndex = 5;
            this.btnIniSesion.Text = "Iniciar Sesion";
            this.btnIniSesion.UseVisualStyleBackColor = true;
            this.btnIniSesion.Click += new System.EventHandler(this.btnIniSesion_Click);
            // 
            // cbConsulta
            // 
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Items.AddRange(new object[] {
            "Consultar Restricciones Usuario",
            "Consultar Objetos Usuario",
            "Consultar Tablas"});
            this.cbConsulta.Location = new System.Drawing.Point(299, 63);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(172, 21);
            this.cbConsulta.TabIndex = 6;
            this.cbConsulta.Text = "Consultas";
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // lblSelConsulta
            // 
            this.lblSelConsulta.AutoSize = true;
            this.lblSelConsulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelConsulta.Location = new System.Drawing.Point(296, 20);
            this.lblSelConsulta.Name = "lblSelConsulta";
            this.lblSelConsulta.Size = new System.Drawing.Size(266, 18);
            this.lblSelConsulta.TabIndex = 7;
            this.lblSelConsulta.Text = "Selecciona la consulta a realizar";
            // 
            // cbSelOpc2
            // 
            this.cbSelOpc2.FormattingEnabled = true;
            this.cbSelOpc2.Items.AddRange(new object[] {
            "Tabla",
            "Indice",
            "Vista",
            "procedimiento",
            "Funcion",
            "Trigger",
            "Paquete"});
            this.cbSelOpc2.Location = new System.Drawing.Point(545, 94);
            this.cbSelOpc2.Name = "cbSelOpc2";
            this.cbSelOpc2.Size = new System.Drawing.Size(148, 21);
            this.cbSelOpc2.TabIndex = 8;
            this.cbSelOpc2.Text = "Objetos";
            this.cbSelOpc2.Visible = false;
            this.cbSelOpc2.SelectedIndexChanged += new System.EventHandler(this.cbSelOpc2_SelectedIndexChanged);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(299, 202);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(585, 255);
            this.dgvConsulta.TabIndex = 9;
            // 
            // lblSel2
            // 
            this.lblSel2.AutoSize = true;
            this.lblSel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSel2.Location = new System.Drawing.Point(296, 99);
            this.lblSel2.Name = "lblSel2";
            this.lblSel2.Size = new System.Drawing.Size(237, 16);
            this.lblSel2.TabIndex = 10;
            this.lblSel2.Text = "Seleccione el Objeto a consultar:";
            this.lblSel2.Visible = false;
            // 
            // lblSel3
            // 
            this.lblSel3.AutoSize = true;
            this.lblSel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSel3.Location = new System.Drawing.Point(296, 133);
            this.lblSel3.Name = "lblSel3";
            this.lblSel3.Size = new System.Drawing.Size(226, 16);
            this.lblSel3.TabIndex = 11;
            this.lblSel3.Text = "Seleccione la tabla a consultar:";
            this.lblSel3.Visible = false;
            // 
            // cbSelOpc3
            // 
            this.cbSelOpc3.FormattingEnabled = true;
            this.cbSelOpc3.Location = new System.Drawing.Point(545, 128);
            this.cbSelOpc3.Name = "cbSelOpc3";
            this.cbSelOpc3.Size = new System.Drawing.Size(148, 21);
            this.cbSelOpc3.TabIndex = 12;
            this.cbSelOpc3.Text = "Tablas";
            this.cbSelOpc3.Visible = false;
            this.cbSelOpc3.SelectedIndexChanged += new System.EventHandler(this.cbSelOpc3_SelectedIndexChanged);
            // 
            // lblIntroduc
            // 
            this.lblIntroduc.AutoSize = true;
            this.lblIntroduc.BackColor = System.Drawing.Color.White;
            this.lblIntroduc.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduc.ForeColor = System.Drawing.Color.Maroon;
            this.lblIntroduc.Location = new System.Drawing.Point(13, 62);
            this.lblIntroduc.Name = "lblIntroduc";
            this.lblIntroduc.Size = new System.Drawing.Size(235, 76);
            this.lblIntroduc.TabIndex = 13;
            this.lblIntroduc.Text = "Bienvenido, por favor digite el usuario\r\ny contraseña de Oracle para acceder\r\na l" +
    "as funcionalidades del Visor del \r\nDiccionario de Datos. ";
            // 
            // lblSelOpc3
            // 
            this.lblSelOpc3.AutoSize = true;
            this.lblSelOpc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelOpc3.ForeColor = System.Drawing.Color.Red;
            this.lblSelOpc3.Location = new System.Drawing.Point(301, 157);
            this.lblSelOpc3.Name = "lblSelOpc3";
            this.lblSelOpc3.Size = new System.Drawing.Size(0, 18);
            this.lblSelOpc3.TabIndex = 14;
            // 
            // FormSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(898, 469);
            this.Controls.Add(this.lblSelOpc3);
            this.Controls.Add(this.lblIntroduc);
            this.Controls.Add(this.cbSelOpc3);
            this.Controls.Add(this.lblSel3);
            this.Controls.Add(this.lblSel2);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cbSelOpc2);
            this.Controls.Add(this.lblSelConsulta);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.btnIniSesion);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.MaximizeBox = false;
            this.Name = "FormSesion";
            this.Text = "Visor Diccionario de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIniSesion;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label lblSelConsulta;
        private System.Windows.Forms.ComboBox cbSelOpc2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblSel2;
        private System.Windows.Forms.Label lblSel3;
        private System.Windows.Forms.ComboBox cbSelOpc3;
        private System.Windows.Forms.Label lblIntroduc;
        private System.Windows.Forms.Label lblSelOpc3;
    }
}

