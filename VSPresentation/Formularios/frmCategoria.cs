using SVServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSPresentation.ViewModels;
using VSPresentation.Utilidades;
using VSPresentation.Utilidades.Objetos;
using static Azure.Core.HttpHeader;
using System.Threading.Tasks.Dataflow;
using SVRepository.Entities;

namespace VSPresentation.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;

        public frmCategoria(IMedidaService medidaService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            _medidaService = medidaService;
            _categoriaService = categoriaService;
        }

        public void MostraTab(string tabName)
        {
            var TabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabCtrlMain;
                }
            }
        }

        private async Task MostrarCategorias(string buscar = "")
        {
            var listaCategorias = await _categoriaService.lista(buscar);

            var listaVM = listaCategorias.Select(item => new CategoriaVM
            {
                IdCategoria = item.IdCategoria,
                Nombre = item.Nombre,
                IdMedida = item.ReMedida.IdMedida,
                Medida = item.ReMedida.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvCategorias.DataSource = listaVM;
            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
            dgvCategorias.ImplementarConfiguracion("Editar");
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarCategorias();

            OpcionCombo[] itemHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{Texto="Si",Valor = 1},
                new OpcionCombo{Texto="No",Valor = 0}
            };

            var listaMedida = await _medidaService.lista();
            var items = listaMedida.Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdMedida }).ToArray();

            cmbMedidaNuevo.InsertarItems(items);
            cmbMedidaEditar.InsertarItems(items);
            cmbHabilitado.InsertarItems(itemHabilitados);

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarCategorias(txbBuscar.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            txbNombreNuevo.Text = "";
            cmbMedidaNuevo.SelectedIndex = 0;
            txbNombreNuevo.Select();

            MostraTab(tabNuevo.Name);
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
        }



        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el nombre");
                return;
            }
            var item = ((OpcionCombo)cmbMedidaNuevo.SelectedItem);
            var objeto = new Categoria
            {
                Nombre = txbNombreNuevo.Text.Trim(),
                ReMedida = new Medida { IdMedida = item.Valor }
            };

            var respuesta = await _categoriaService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategorias();
                MostraTab(tabLista.Name);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;

                txbNombreEditar.Text = categoriaSeleccionada.Nombre.ToString();

                cmbMedidaEditar.EstablecerValor(categoriaSeleccionada.IdMedida);
                cmbHabilitado.EstablecerValor(categoriaSeleccionada.Activo);


                MostraTab(tabEditar.Name);
                txbNombreEditar.Select();
            }
        }
        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbNombreEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el nombre");
                return;
            }

            var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;

            var objeto = new Categoria
            {
                IdCategoria = categoriaSeleccionada.IdCategoria,
                Nombre = txbNombreEditar.Text.Trim(),
                ReMedida = new Medida { IdMedida = ((OpcionCombo)cmbMedidaEditar.SelectedItem).Valor },
                Activo = ((OpcionCombo)cmbHabilitado.SelectedItem).Valor

            };

            var respuesta = await _categoriaService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategorias();
                MostraTab(tabLista.Name);
            }
        }
    }
}
