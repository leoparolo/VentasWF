namespace VSPresentation.Formularios
{
    partial class frmCategoria
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
            tabCtrlMain = new TabControl();
            tabLista = new TabPage();
            dgvCategorias = new DataGridView();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabNuevo = new TabPage();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cmbMedidaNuevo = new ComboBox();
            label2 = new Label();
            txbNombreNuevo = new TextBox();
            Nombre = new Label();
            tabEditar = new TabPage();
            cmbHabilitado = new ComboBox();
            label5 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cmbMedidaEditar = new ComboBox();
            label3 = new Label();
            txbNombreEditar = new TextBox();
            label4 = new Label();
            label1 = new Label();
            tabCtrlMain.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabCtrlMain
            // 
            tabCtrlMain.Controls.Add(tabLista);
            tabCtrlMain.Controls.Add(tabNuevo);
            tabCtrlMain.Controls.Add(tabEditar);
            tabCtrlMain.ItemSize = new Size(80, 20);
            tabCtrlMain.Location = new Point(12, 35);
            tabCtrlMain.Name = "tabCtrlMain";
            tabCtrlMain.SelectedIndex = 0;
            tabCtrlMain.Size = new Size(740, 344);
            tabCtrlMain.SizeMode = TabSizeMode.Fixed;
            tabCtrlMain.TabIndex = 0;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvCategorias);
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
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(6, 35);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(720, 275);
            dgvCategorias.TabIndex = 4;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(651, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(488, 7);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(157, 23);
            txbBuscar.TabIndex = 2;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(5, 6);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 1;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cmbMedidaNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Controls.Add(txbNombreNuevo);
            tabNuevo.Controls.Add(Nombre);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(651, 287);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(75, 23);
            btnGuardarNuevo.TabIndex = 5;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(15, 287);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(75, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cmbMedidaNuevo
            // 
            cmbMedidaNuevo.Cursor = Cursors.Hand;
            cmbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedidaNuevo.FormattingEnabled = true;
            cmbMedidaNuevo.Location = new Point(15, 92);
            cmbMedidaNuevo.Name = "cmbMedidaNuevo";
            cmbMedidaNuevo.Size = new Size(711, 23);
            cmbMedidaNuevo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Medida";
            // 
            // txbNombreNuevo
            // 
            txbNombreNuevo.Location = new Point(15, 33);
            txbNombreNuevo.Name = "txbNombreNuevo";
            txbNombreNuevo.Size = new Size(711, 23);
            txbNombreNuevo.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(15, 15);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cmbHabilitado);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cmbMedidaEditar);
            tabEditar.Controls.Add(label3);
            tabEditar.Controls.Add(txbNombreEditar);
            tabEditar.Controls.Add(label4);
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
            cmbHabilitado.Location = new Point(11, 156);
            cmbHabilitado.Name = "cmbHabilitado";
            cmbHabilitado.Size = new Size(711, 23);
            cmbHabilitado.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 138);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 12;
            label5.Text = "Habilitado";
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
            // cmbMedidaEditar
            // 
            cmbMedidaEditar.Cursor = Cursors.Hand;
            cmbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedidaEditar.FormattingEnabled = true;
            cmbMedidaEditar.Location = new Point(11, 88);
            cmbMedidaEditar.Name = "cmbMedidaEditar";
            cmbMedidaEditar.Size = new Size(711, 23);
            cmbMedidaEditar.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 70);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Medida";
            // 
            // txbNombreEditar
            // 
            txbNombreEditar.Location = new Point(11, 29);
            txbNombreEditar.Name = "txbNombreEditar";
            txbNombreEditar.Size = new Size(711, 23);
            txbNombreEditar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 11);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventario / Categoria";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabCtrlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            Load += frmCategoria_Load;
            tabCtrlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabCtrlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Label label1;
        private TabPage tabEditar;
        private TextBox txbBuscar;
        private Button btnNuevoLista;
        private Button btnBuscar;
        private DataGridView dgvCategorias;
        private Label Nombre;
        private TextBox txbNombreNuevo;
        private ComboBox cmbMedidaNuevo;
        private Label label2;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cmbMedidaEditar;
        private Label label3;
        private TextBox txbNombreEditar;
        private Label label4;
        private ComboBox cmbHabilitado;
        private Label label5;
    }
}