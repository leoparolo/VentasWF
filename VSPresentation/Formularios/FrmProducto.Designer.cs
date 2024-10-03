namespace VSPresentation.Formularios
{
    partial class FrmProducto
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
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cmbCategoriaNuevo = new ComboBox();
            label2 = new Label();
            tabEditar = new TabPage();
            cmbHabilitado = new ComboBox();
            label13 = new Label();
            label3 = new Label();
            txtCantidadEditar = new NumericUpDown();
            txtPrecioVentaEditar = new TextBox();
            label4 = new Label();
            txtPrecioCompraEditar = new TextBox();
            label5 = new Label();
            txtDescripcionEditar = new TextBox();
            label10 = new Label();
            cmbCategoriaEditar = new ComboBox();
            label11 = new Label();
            txtCodigoEditar = new TextBox();
            label12 = new Label();
            txbCodigoNuevo = new TextBox();
            tabNuevo = new TabPage();
            label9 = new Label();
            txtCantidadNuevo = new NumericUpDown();
            txtPrecioVentaNuevo = new TextBox();
            label8 = new Label();
            txtPrecioCompraNuevo = new TextBox();
            label7 = new Label();
            txtDescripcionNuevo = new TextBox();
            label6 = new Label();
            Nombre = new Label();
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabCtrlMain = new TabControl();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadEditar).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabLista.SuspendLayout();
            tabCtrlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Inventario / Producto";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(647, 283);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 11;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(11, 283);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 10;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.BackColor = Color.White;
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(651, 287);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(75, 23);
            btnGuardarNuevo.TabIndex = 5;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = false;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.BackColor = Color.White;
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(15, 287);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(75, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = false;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cmbCategoriaNuevo
            // 
            cmbCategoriaNuevo.Cursor = Cursors.Hand;
            cmbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaNuevo.FormattingEnabled = true;
            cmbCategoriaNuevo.Location = new Point(15, 25);
            cmbCategoriaNuevo.Name = "cmbCategoriaNuevo";
            cmbCategoriaNuevo.Size = new Size(308, 23);
            cmbCategoriaNuevo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 10);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cmbHabilitado);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(label3);
            tabEditar.Controls.Add(txtCantidadEditar);
            tabEditar.Controls.Add(txtPrecioVentaEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txtPrecioCompraEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(txtDescripcionEditar);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(cmbCategoriaEditar);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(txtCodigoEditar);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cmbHabilitado
            // 
            cmbHabilitado.Cursor = Cursors.Hand;
            cmbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHabilitado.FormattingEnabled = true;
            cmbHabilitado.Location = new Point(352, 75);
            cmbHabilitado.Name = "cmbHabilitado";
            cmbHabilitado.Size = new Size(370, 23);
            cmbHabilitado.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(355, 60);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 26;
            label13.Text = "Habilitado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 3);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 25;
            label3.Text = "Cantidad";
            // 
            // txtCantidadEditar
            // 
            txtCantidadEditar.Location = new Point(352, 21);
            txtCantidadEditar.Name = "txtCantidadEditar";
            txtCantidadEditar.Size = new Size(370, 23);
            txtCantidadEditar.TabIndex = 24;
            // 
            // txtPrecioVentaEditar
            // 
            txtPrecioVentaEditar.Location = new Point(11, 254);
            txtPrecioVentaEditar.Name = "txtPrecioVentaEditar";
            txtPrecioVentaEditar.Size = new Size(305, 23);
            txtPrecioVentaEditar.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 236);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 22;
            label4.Text = "Precio Venta";
            // 
            // txtPrecioCompraEditar
            // 
            txtPrecioCompraEditar.Location = new Point(11, 197);
            txtPrecioCompraEditar.Name = "txtPrecioCompraEditar";
            txtPrecioCompraEditar.Size = new Size(305, 23);
            txtPrecioCompraEditar.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 179);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 20;
            label5.Text = "Precio Compra";
            // 
            // txtDescripcionEditar
            // 
            txtDescripcionEditar.Location = new Point(11, 136);
            txtDescripcionEditar.Name = "txtDescripcionEditar";
            txtDescripcionEditar.Size = new Size(305, 23);
            txtDescripcionEditar.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 118);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 18;
            label10.Text = "Descripcion";
            // 
            // cmbCategoriaEditar
            // 
            cmbCategoriaEditar.Cursor = Cursors.Hand;
            cmbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaEditar.FormattingEnabled = true;
            cmbCategoriaEditar.Location = new Point(11, 21);
            cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            cmbCategoriaEditar.Size = new Size(308, 23);
            cmbCategoriaEditar.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 6);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 16;
            label11.Text = "Categoria";
            // 
            // txtCodigoEditar
            // 
            txtCodigoEditar.Location = new Point(11, 75);
            txtCodigoEditar.Name = "txtCodigoEditar";
            txtCodigoEditar.Size = new Size(305, 23);
            txtCodigoEditar.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 57);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 14;
            label12.Text = "Codigo";
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(15, 79);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(305, 23);
            txbCodigoNuevo.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txtCantidadNuevo);
            tabNuevo.Controls.Add(txtPrecioVentaNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txtPrecioCompraNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(txtDescripcionNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cmbCategoriaNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(Nombre);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 7);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 13;
            label9.Text = "Cantidad";
            // 
            // txtCantidadNuevo
            // 
            txtCantidadNuevo.Location = new Point(356, 25);
            txtCantidadNuevo.Name = "txtCantidadNuevo";
            txtCantidadNuevo.Size = new Size(370, 23);
            txtCantidadNuevo.TabIndex = 12;
            // 
            // txtPrecioVentaNuevo
            // 
            txtPrecioVentaNuevo.Location = new Point(15, 258);
            txtPrecioVentaNuevo.Name = "txtPrecioVentaNuevo";
            txtPrecioVentaNuevo.Size = new Size(305, 23);
            txtPrecioVentaNuevo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 240);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 10;
            label8.Text = "Precio Venta";
            // 
            // txtPrecioCompraNuevo
            // 
            txtPrecioCompraNuevo.Location = new Point(15, 201);
            txtPrecioCompraNuevo.Name = "txtPrecioCompraNuevo";
            txtPrecioCompraNuevo.Size = new Size(305, 23);
            txtPrecioCompraNuevo.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 183);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 8;
            label7.Text = "Precio Compra";
            // 
            // txtDescripcionNuevo
            // 
            txtDescripcionNuevo.Location = new Point(15, 140);
            txtDescripcionNuevo.Name = "txtDescripcionNuevo";
            txtDescripcionNuevo.Size = new Size(305, 23);
            txtDescripcionNuevo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 122);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 6;
            label6.Text = "Descripcion";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(15, 61);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(46, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Codigo";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 35);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(720, 275);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(651, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(438, 7);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(207, 23);
            txbBuscar.TabIndex = 2;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.BackColor = Color.White;
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(5, 6);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 1;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = false;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabCtrlMain
            // 
            tabCtrlMain.Controls.Add(tabLista);
            tabCtrlMain.Controls.Add(tabNuevo);
            tabCtrlMain.Controls.Add(tabEditar);
            tabCtrlMain.ItemSize = new Size(80, 20);
            tabCtrlMain.Location = new Point(12, 44);
            tabCtrlMain.Name = "tabCtrlMain";
            tabCtrlMain.SelectedIndex = 0;
            tabCtrlMain.Size = new Size(740, 344);
            tabCtrlMain.SizeMode = TabSizeMode.Fixed;
            tabCtrlMain.TabIndex = 2;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabCtrlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadEditar).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabCtrlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cmbCategoriaNuevo;
        private Label label2;
        private TabPage tabEditar;
        private TextBox txbCodigoNuevo;
        private TabPage tabNuevo;
        private Label Nombre;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabCtrlMain;
        private TextBox txtPrecioCompraNuevo;
        private Label label7;
        private TextBox txtDescripcionNuevo;
        private Label label6;
        private TextBox txtPrecioVentaNuevo;
        private Label label8;
        private Label label9;
        private NumericUpDown txtCantidadNuevo;
        private ComboBox cmbHabilitado;
        private Label label13;
        private Label label3;
        private NumericUpDown txtCantidadEditar;
        private TextBox txtPrecioVentaEditar;
        private Label label4;
        private TextBox txtPrecioCompraEditar;
        private Label label5;
        private TextBox txtDescripcionEditar;
        private Label label10;
        private ComboBox cmbCategoriaEditar;
        private Label label11;
        private TextBox txtCodigoEditar;
        private Label label12;
    }
}