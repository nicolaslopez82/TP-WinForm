using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace vista
{
    public partial class AltaArticulo : Form
    {
        private Articulo Art = null;
        public AltaArticulo()
        {
            InitializeComponent();
        }
        public AltaArticulo(Articulo Articulo)
        {
            this.Art = Articulo;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                if (Art == null)
                    Art = new Articulo();

                Art.Codigo = txtCodigo.Text;
                Art.Nombre = txtNombre.Text;
                Art.Descripcion = txtDesc.Text;
                Art.Marca = (Marca)cboMarca.SelectedItem;
                Art.Categoria = (Catalogo)cboCategoria.SelectedItem;
                Art.Imagen = txtUrlImagen.Text;
                Art.Precio = decimal.Parse(txtPrecio.Text);
                if (Art.Id != 0)
                {
                    negocio.modificar(Art);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(Art);
                    MessageBox.Show("Agregado Exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio NegocioMar = new MarcaNegocio();
            Catalogo_Negocio NegocioCat = new Catalogo_Negocio();
            try
            {
                cboMarca.DataSource = NegocioMar.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = NegocioCat.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (Art != null)
                {
                    txtCodigo.Text = Art.Codigo;
                    txtNombre.Text = Art.Nombre;
                    txtDesc.Text = Art.Descripcion;
                    txtUrlImagen.Text = Art.Imagen;
                    cboMarca.SelectedValue = Art.Marca.Id;
                    cboCategoria.SelectedValue = Art.Categoria.Id;
                    txtPrecio.Text = Art.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
