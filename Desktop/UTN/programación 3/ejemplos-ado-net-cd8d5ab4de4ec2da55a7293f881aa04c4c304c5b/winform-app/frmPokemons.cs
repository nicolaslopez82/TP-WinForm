using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;

namespace winform_app
{
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listapokemon;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.listar();
            dgvPokemons.DataSource = listapokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            PicPokemon.Load(listapokemon[0].UrlImagen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado=  (Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            PicPokemon.Load(seleccionado.UrlImagen);
        }
    }
}
