using SVServices.Implementation;
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
using VSPresentation.Utilidades.Objetos;
using VSPresentation.Utilidades;
using VSPresentation.ViewModels;
using SVRepository.Entities;

namespace VSPresentation.Formularios
{
    public partial class FrmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        public FrmProducto(IProductoService productoService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
        }
        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.lista(buscar);

            var listaVM = listaProductos.Select(item => new ProductoVM
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra,
                PrecioVenta = item.PrecioVenta,
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvProductos.DataSource = listaVM;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
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

        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
            dgvProductos.ImplementarConfiguracion("Editar");
            txtPrecioCompraNuevo.ValidarNumero();
            txtPrecioCompraEditar.ValidarNumero();
            txtPrecioVentaNuevo.ValidarNumero();
            txtPrecioVentaEditar.ValidarNumero();
            await MostrarProductos();

            OpcionCombo[] itemHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{Texto="Si",Valor = 1},
                new OpcionCombo{Texto="No",Valor = 0}
            };

            var listaCategoria = await _categoriaService.lista();
            var items = listaCategoria
                .Where(item => item.Activo == 1)
                .Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdCategoria })
                .ToArray();

            cmbCategoriaNuevo.InsertarItems(items);
            cmbCategoriaEditar.InsertarItems(items);

            cmbHabilitado.InsertarItems(itemHabilitados);


        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txbBuscar.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            MostraTab(tabNuevo.Name);
            cmbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = "";
            txtDescripcionNuevo.Text = "";
            txtPrecioCompraNuevo.Text = "";
            txtPrecioVentaNuevo.Text = "";
            txtCantidadNuevo.Value = 0;
            cmbCategoriaNuevo.Select();
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
        }

        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbCodigoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo");
                return;
            }
            if (txtDescripcionNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion");
                return;
            }
            if (txtPrecioCompraNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio compra");
                return;
            }
            if (txtPrecioVentaNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio venta");
                return;
            }
            if (txtCantidadNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad");
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;

            if (!decimal.TryParse(txtPrecioCompraNuevo.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtPrecioCompraNuevo.Select();
                return;
            }

            if (!decimal.TryParse(txtPrecioVentaNuevo.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtPrecioCompraNuevo.Select();
                return;
            }


            var objeto = new Producto
            {
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cmbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txbCodigoNuevo.Text.Trim(),
                Descripcion = txtDescripcionNuevo.Text.Trim(),
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Cantidad = Convert.ToInt32(txtCantidadNuevo.Value)

            };

            var respuesta = await _productoService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostraTab(tabLista.Name);
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var productoSeleccionada = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;

                cmbCategoriaEditar.EstablecerValor(productoSeleccionada.IdCategoria);
                txtCodigoEditar.Text = productoSeleccionada.Codigo;
                txtDescripcionEditar.Text = productoSeleccionada.Descripcion;
                txtPrecioCompraEditar.Text = productoSeleccionada.PrecioCompra.ToString();
                txtPrecioVentaEditar.Text = productoSeleccionada.PrecioVenta.ToString();
                txtCantidadEditar.Value = productoSeleccionada.Cantidad;
                cmbHabilitado.EstablecerValor(productoSeleccionada.Activo);

                MostraTab(tabEditar.Name);
                cmbCategoriaEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostraTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo");
                return;
            }
            if (txtDescripcionEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion");
                return;
            }
            if (txtPrecioCompraEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio compra");
                return;
            }
            if (txtPrecioVentaEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio venta");
                return;
            }
            if (txtCantidadEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad");
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;

            if (!decimal.TryParse(txtPrecioCompraNuevo.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtPrecioCompraEditar.Select();
                return;
            }

            if (!decimal.TryParse(txtPrecioVentaNuevo.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtPrecioCompraEditar.Select();
                return;
            }

            var productoSeleccionada = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;

            var objeto = new Producto
            {
                IdProducto = productoSeleccionada.IdProducto,
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cmbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txtCodigoEditar.Text.Trim(),
                Descripcion = txtDescripcionEditar.Text.Trim(),
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Cantidad = Convert.ToInt32(txtCantidadEditar.Value),
                Activo = ((OpcionCombo)cmbHabilitado.SelectedItem!).Valor

            };

            var respuesta = await _productoService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostraTab(tabLista.Name);
            }
        }
    }
}
