namespace ClientesApp.Forms
{
    partial class formulario
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
            this.nombres = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Location = new System.Drawing.Point(64, 40);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(56, 15);
            this.nombres.TabIndex = 0;
            this.nombres.Text = "Nombres";
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Location = new System.Drawing.Point(64, 84);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(56, 15);
            this.apellidos.TabIndex = 1;
            this.apellidos.Text = "Apellidos";
            this.apellidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(64, 122);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(57, 15);
            this.direccion.TabIndex = 2;
            this.direccion.Text = "Dirección";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(138, 37);
            this.textNombres.MaxLength = 255;
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(224, 23);
            this.textNombres.TabIndex = 3;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(138, 81);
            this.textApellidos.MaxLength = 255;
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(224, 23);
            this.textApellidos.TabIndex = 4;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(138, 122);
            this.textDireccion.MaxLength = 255;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(224, 23);
            this.textDireccion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(191, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 302);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombres;
        private Label apellidos;
        private Label direccion;
        private TextBox textNombres;
        private TextBox textApellidos;
        private TextBox textDireccion;
        private Button btnGuardar;
    }
}