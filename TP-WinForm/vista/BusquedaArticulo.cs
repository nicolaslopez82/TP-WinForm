using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using ConexionDataBase;

namespace vista
{
    public partial class BusquedaArticulo : Form
    {
        private List<Articulo> ArticulosList;
        public BusquedaArticulo()
        {
            InitializeComponent();
        }

        private void cbxCodigo_Click(object sender, EventArgs e)
        {

            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();
            
            try
            {
                cbxCodigo.DataSource = BusquedaNegocio.ListarCodigos();
                cbxCodigo.DisplayMember = "Codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxNombre_Click(object sender, EventArgs e)
        {
            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            try
            {
                cbxNombre.DataSource = BusquedaNegocio.ListarNombres();
                cbxNombre.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxDescripcion_Click(object sender, EventArgs e)
        {
            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            try
            {
                cbxDescripcion.DataSource = BusquedaNegocio.ListarDescripciones();
                cbxDescripcion.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxMarca_Click(object sender, EventArgs e)
        {
            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            try
            {
                cbxMarca.DataSource = BusquedaNegocio.ListarMarcas();
                cbxMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxCategoria_Click(object sender, EventArgs e)
        {
            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            try
            {
                cbxCategoria.DataSource = BusquedaNegocio.ListarCategorias();
                cbxCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxPrecio_Click(object sender, EventArgs e)
        {
            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            try
            {
                cbxPrecio.DataSource = BusquedaNegocio.listarPrecios();
                cbxPrecio.DisplayMember = "Precio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {

            BusquedaNegocio BusquedaNegocio = new BusquedaNegocio();

            /*String query = ConstantesDB.SQL_QUERY_LISTAR_ARTICULOS.Value +
                " WHERE " +
                "a.Codigo = '" + cbxCodigo.SelectedItem.ToString() + "'";//+
            "' AND '" +
            "'a.Nombre ='" + cbxNombre.SelectedItem.ToString() +
            "' AND '" +
            "'a.Descripcion ='" + cbxDescripcion.SelectedItem.ToString() +
            "' AND '" +
            "'m.Descripcion ='" + cbxMarca.SelectedItem.ToString() +
            "' AND '" +
            "'c.Descripcion ='" + cbxCategoria.SelectedItem.ToString() +
            "' AND '" +
            "'a.Precio ='" + cbxPrecio.SelectedItem.ToString() + "'";*/

            try
            {
                ArticulosList = BusquedaNegocio.BuscarArticulos(ConstantesDB.SQL_QUERY_BUSCAR_ARTICULOS.Value, cbxCodigo.SelectedItem.ToString());
                mainForm form1 = new mainForm();
                form1.listArticulos = ArticulosList;
                form1.dgvArticulos.DataSource = ArticulosList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
