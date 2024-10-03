namespace VSPresentation.Formularios
{
    partial class FrmNegocio
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
            label1 = new Label();
            label2 = new Label();
            txbRazonSocial = new TextBox();
            Nombre = new Label();
            txbRUC = new TextBox();
            label3 = new Label();
            txbDireccion = new TextBox();
            label4 = new Label();
            txbCelular = new TextBox();
            label5 = new Label();
            txbCorreo = new TextBox();
            label6 = new Label();
            txbSimboloMoneda = new TextBox();
            label7 = new Label();
            txbRutaImagen = new TextBox();
            label8 = new Label();
            btnBuscar = new Button();
            pbLogo = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(740, 340);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Configuración";
            // 
            // txbRazonSocial
            // 
            txbRazonSocial.Location = new Point(21, 78);
            txbRazonSocial.Name = "txbRazonSocial";
            txbRazonSocial.Size = new Size(327, 23);
            txbRazonSocial.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(21, 60);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(75, 15);
            Nombre.TabIndex = 3;
            Nombre.Text = "Razón social:";
            // 
            // txbRUC
            // 
            txbRUC.Location = new Point(21, 145);
            txbRUC.Name = "txbRUC";
            txbRUC.Size = new Size(327, 23);
            txbRUC.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 127);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "RUC:";
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(21, 208);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(327, 23);
            txbDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 190);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Dirección:";
            // 
            // txbCelular
            // 
            txbCelular.Location = new Point(21, 273);
            txbCelular.Name = "txbCelular";
            txbCelular.Size = new Size(327, 23);
            txbCelular.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 255);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Celular:";
            // 
            // txbCorreo
            // 
            txbCorreo.Location = new Point(21, 335);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(327, 23);
            txbCorreo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 317);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 11;
            label6.Text = "Correo:";
            // 
            // txbSimboloMoneda
            // 
            txbSimboloMoneda.Location = new Point(396, 78);
            txbSimboloMoneda.Name = "txbSimboloMoneda";
            txbSimboloMoneda.Size = new Size(340, 23);
            txbSimboloMoneda.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 60);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 13;
            label7.Text = "Simbolo moneda:";
            // 
            // txbRutaImagen
            // 
            txbRutaImagen.Location = new Point(396, 145);
            txbRutaImagen.Name = "txbRutaImagen";
            txbRutaImagen.ReadOnly = true;
            txbRutaImagen.Size = new Size(259, 23);
            txbRutaImagen.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(396, 127);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 15;
            label8.Text = "Logo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(661, 144);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(396, 208);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(173, 150);
            pbLogo.TabIndex = 18;
            pbLogo.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardar.Location = new Point(661, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(btnGuardar);
            Controls.Add(pbLogo);
            Controls.Add(btnBuscar);
            Controls.Add(txbRutaImagen);
            Controls.Add(label8);
            Controls.Add(txbSimboloMoneda);
            Controls.Add(label7);
            Controls.Add(txbCorreo);
            Controls.Add(label6);
            Controls.Add(txbCelular);
            Controls.Add(label5);
            Controls.Add(txbDireccion);
            Controls.Add(label4);
            Controls.Add(txbRUC);
            Controls.Add(label3);
            Controls.Add(txbRazonSocial);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNegocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNegocio";
            Load += FrmNegocio_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbRazonSocial;
        private Label Nombre;
        private TextBox txbRUC;
        private Label label3;
        private TextBox txbDireccion;
        private Label label4;
        private TextBox txbCelular;
        private Label label5;
        private TextBox txbCorreo;
        private Label label6;
        private TextBox txbSimboloMoneda;
        private Label label7;
        private TextBox txbRutaImagen;
        private Label label8;
        private Button btnBuscar;
        private PictureBox pbLogo;
        private Button btnGuardar;
    }
}