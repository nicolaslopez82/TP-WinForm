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
    public partial class mainForm : Form
    {
        private List<Articulo> listArticulos;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cATALOGO_DBDataSet.ViewListarArticulos' Puede moverla o quitarla según sea necesario.
            this.viewListarArticulosTableAdapter.Fill(this.cATALOGO_DBDataSet.ViewListarArticulos);
            // TODO: esta línea de código carga datos en la tabla 'cATALOGO_DBDataSet21.ViewListarArticulos' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'cATALOGO_DBDataSetArticulos.ARTICULOS' Puede moverla o quitarla según sea necesario.

            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listArticulos = negocio.listar();
                dgvArticulos.DataSource = listArticulos;
                dgvArticulos.Columns["Imagen"].Visible = false;              
                cargarImagen(listArticulos[0].Imagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                picArticulo.Load("https://www.oleoshop.com/imagenes/poridentidad?identidad=8f4d86f3-c26a-46d3-8310-749242865b31&ancho=850&alto=");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnEditarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            AltaArticulo modificacion = new AltaArticulo(seleccionado);
            modificacion.ShowDialog();
            cargar();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
             Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;                       

            if (MessageBox.Show("Desea eliminar el articulo seleccionado?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Eliminar(seleccionado);
                MessageBox.Show("Articulo Eliminado", "Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Articulo No Eliminado", "Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargar();
        }

        private void aRTICULOSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
